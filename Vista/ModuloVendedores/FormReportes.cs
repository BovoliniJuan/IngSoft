using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf; 
using iText.Layout; 
using iText.Layout.Element; 
using System.Collections.ObjectModel;
using Entidades;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.IO.Image;
using Color = System.Drawing.Color;
using Entidades.Seguridad2;
using System.Windows.Forms.DataVisualization.Charting;
using Controladoras.Vendedor;
using Entidades.EntidadesVendedores;

namespace Vista.ModuloVendedores
{
    public partial class FormReportes : Form
    {
        Sesion? _sesion;
        public FormReportes(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;

            // Cargar el primer reporte como predeterminado si existe una opción
            if (cmbTipoReporte.Items.Count > 0)
            {
                cmbTipoReporte.SelectedIndex = 0; // Selecciona el primer reporte
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Crear la ruta para guardar el PDF en la carpeta correspondiente
            string pdfPath = CrearRutaPdf();

            using (var writer = new PdfWriter(pdfPath))
            using (var pdf = new PdfDocument(writer))
            {
                var document = new Document(pdf);

                // Agregar encabezado común
                AgregarEncabezado(document);

                // Verificar el reporte seleccionado y exportar el reporte correspondiente
                switch (cmbTipoReporte.SelectedIndex)
                {
                    case 0:
                        var productosMasVendidos = ControladoraReportes.Instancia.RecuperarProductosMasVendidos(_sesion);
                        AgregarTablaProductos(document, productosMasVendidos, "Productos Más Vendidos", "Cantidad Vendida");


                        // Agregar margen entre la tabla y el gráfico
                        document.Add(new Paragraph("\n").SetMarginTop(20));

                        // Agregar el gráfico debajo de la tabla
                        AgregarGraficoProductosMasVendidos(document, productosMasVendidos);
                        break;

                    case 1:
                        var productosMenosVendidos = ControladoraReportes.Instancia.RecuperarProductosMenosVendidos(_sesion);
                        AgregarTablaProductos(document, productosMenosVendidos, "Productos Menos Vendidos", "Cantidad Vendida");
                        break;

                    case 2:
                        var productosMasRentables = ControladoraReportes.Instancia.RecuperarProductosMasRentables(_sesion);
                        AgregarTablaProductosMasRentables(document, productosMasRentables);
                        break;
                }

                document.Close(); // Cerrar el documento
            }

            // Informar al usuario que el archivo se ha creado
            MessageBox.Show($"PDF exportado correctamente a {pdfPath}");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string CrearRutaPdf()
        {
            // Obtener la ruta del escritorio del usuario
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Definir la ruta de la carpeta principal
            string folderPath = System.IO.Path.Combine(desktopPath, "PDFS AgroGestion");

            // Crear la carpeta principal si no existe
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Subcarpetas específicas para cada tipo de reporte
            string subfolderPath;
            switch (cmbTipoReporte.SelectedIndex)
            {
                case 0:
                    subfolderPath = System.IO.Path.Combine(folderPath, "Reportes Productos mas vendidas");
                    break;
                case 1:
                    subfolderPath = System.IO.Path.Combine(folderPath, "Reportes Productos menos vendidos");
                    break;
                case 2:
                    subfolderPath = System.IO.Path.Combine(folderPath, "Reportes Productos mas rentables");
                    break;

                default:
                    subfolderPath = folderPath;
                    break;
            }

            // Crear la subcarpeta si no existe
            if (!System.IO.Directory.Exists(subfolderPath))
            {
                System.IO.Directory.CreateDirectory(subfolderPath);
            }

            // Cambiar el nombre del archivo PDF basado en el reporte seleccionado
            string fileName;
            switch (cmbTipoReporte.SelectedIndex)
            {
                case 0:
                    fileName = $"ProductosMasVendidos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    break;
                case 1:
                    fileName = $"ProductosMenosVendidos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    break;
                case 2:
                    fileName = $"ProductosMasRentables_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    break;
                default:
                    fileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    break;
            }

            return System.IO.Path.Combine(subfolderPath, fileName);
        }
        // Métodos para agregar tablas y encabezados (sin cambios)





        // Método para agregar el encabezado al documento
        private void AgregarEncabezado(Document document)
        {
            var title = new Paragraph("CineManager")
                .SetFontSize(28)
                .SetBold()
                .SetFontColor(ColorConstants.BLACK)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetPadding(10);

            var date = new Paragraph($"Fecha de Generación: {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                .SetFontSize(12)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            document.Add(title);
            document.Add(date);
            document.Add(new Paragraph("\n"));
        }




        private void AgregarTablaProductosMasRentables(Document document, ReadOnlyCollection<(Producto, float)> productosMasRentables)
        {
            var table = new Table(3).SetWidth(UnitValue.CreatePercentValue(100));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Descripcion").SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Ingreso Total").SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));

            foreach (var producto in productosMasRentables)
            {
                table.AddCell(new Cell().Add(new Paragraph(producto.Item1.Nombre)));
                table.AddCell(new Cell().Add(new Paragraph(producto.Item1.Descripcion)));
                table.AddCell(new Cell().Add(new Paragraph(producto.Item2.ToString("C2"))));
            }

            document.Add(table);
        }

        private void AgregarTablaProductos(Document document, ReadOnlyCollection<(Producto, int)> productos, string titulo, string columnaCantidad)
        {
            var table = new Table(3).SetWidth(UnitValue.CreatePercentValue(100));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Descripcion").SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));
            table.AddHeaderCell(new Cell().Add(new Paragraph(columnaCantidad).SetBold().SetFontColor(ColorConstants.WHITE))
                .SetBackgroundColor(new DeviceRgb(50, 100, 200)));

            foreach (var producto in productos)
            {
                table.AddCell(new Cell().Add(new Paragraph(producto.Item1.Nombre)));
                table.AddCell(new Cell().Add(new Paragraph(producto.Item1.Descripcion)));
                table.AddCell(new Cell().Add(new Paragraph(producto.Item2.ToString())));
            }

            document.Add(new Paragraph(titulo).SetFontSize(16).SetBold().SetMarginBottom(10));
            document.Add(table);
        }
        private void AgregarGraficoProductosMasVendidos(Document document, ReadOnlyCollection<(Producto, int)> productosMasVendidos)
        {
            // Crear el gráfico con estilo modernizado
            Chart chart = new Chart
            {
                Width = 600,
                Height = 400
            };

            var chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.White, // Fondo blanco para un estilo limpio
                AxisX =
                {
                    Interval = 1,
                    LabelStyle = { Font = new Font("Arial", 10, FontStyle.Bold), ForeColor = Color.Gray },
                    LineColor = Color.LightGray // Color gris claro para el eje X
                },
                AxisY =
                {
                    LabelStyle = { Font = new Font("Arial", 10), ForeColor = Color.Gray },
                    LineColor = Color.LightGray // Color gris claro para el eje Y
                }
            };
            chart.ChartAreas.Add(chartArea);

            var series = new Series("Ventas")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.FromArgb(102, 204, 255), // Color azul suave para las barras
                BorderWidth = 0,
                IsValueShownAsLabel = true, // Mostrar los valores encima de cada barra
                LabelForeColor = Color.DimGray, // Color gris oscuro para las etiquetas de valores
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            chart.Series.Add(series);

            // Agregar degradado de color para un efecto más moderno
            series.BackGradientStyle = GradientStyle.LeftRight;
            series.BackSecondaryColor = Color.FromArgb(51, 153, 255); // Azul más oscuro para el gradiente

            // Agregar datos al gráfico
            foreach (var producto in productosMasVendidos)
            {
                series.Points.AddXY(producto.Item1.Nombre, producto.Item2);
            }

            // Guardar el gráfico como imagen
            string imagePath = Path.Combine(Path.GetTempPath(), "grafico_productos_mas_vendidos.png");
            chart.SaveImage(imagePath, ChartImageFormat.Png);

            // Agregar la imagen al PDF
            ImageData imageData = ImageDataFactory.Create(imagePath);
            iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData)
                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                .SetMarginTop(20); // Espacio entre la tabla y el gráfico
            document.Add(pdfImage);

            // Borrar el archivo temporal de imagen
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }

        private void MostrarProductosMasVendidas()
        {
            // Llama al método para recuperar las películas más vendidas y asigna los datos al DataGridView
            var productosMasVendidas = ControladoraReportes.Instancia.RecuperarProductosMasVendidos(_sesion)
                .Select(p => new
                {
                    Nombre = p.Item1?.Nombre ?? "Desconocido",
                    Descripcion = p.Item1?.Descripcion ?? "Sin descripcion",
                    CantidadVendida = p.Item2
                })
                .ToList();

            dgvReportes.DataSource = null; // Limpia el DataGridView
            dgvReportes.DataSource = productosMasVendidas;
        }

        private void MostrarProductosMenosVendidos()
        {
            // Llama al método para recuperar los proveedores con órdenes pendientes y asigna los datos al DataGridView
            var productosMenosVendidas = ControladoraReportes.Instancia.RecuperarProductosMenosVendidos(_sesion)
                .Select(p => new
                {
                    Nombre = p.Item1?.Nombre ?? "Desconocido",
                    Descripcion = p.Item1?.Descripcion ?? "Sin descripcion",
                    CantidadVendida = p.Item2
                })
                .ToList();

            dgvReportes.DataSource = null; // Limpia el DataGridView
            dgvReportes.DataSource = productosMenosVendidas;
        }


        private void MostrarProductosMasRentables()
        {
            // Llama al método para recuperar las películas con baja disponibilidad y asigna los datos al DataGridView
            var peliculasConBajaDisponibilidad = ControladoraReportes.Instancia.RecuperarProductosMasRentables(_sesion)
                .Select(p => new
                {
                    Nombre = p.Item1?.Nombre ?? "Desconocido",
                    Descripcion = p.Item1?.Descripcion ?? "Sin descripcion",
                    CantidadInventario = p.Item2 // Accede directamente a la propiedad de la entidad Pelicula
                })
                .ToList();

            dgvReportes.DataSource = null; // Limpia el DataGridView
            dgvReportes.DataSource = peliculasConBajaDisponibilidad;
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Usar SelectedIndex para verificar la selección en el ComboBox
            switch (cmbTipoReporte.SelectedIndex)
            {
                case 0:
                    MostrarProductosMasVendidas();
                    break;
                case 1:
                    MostrarProductosMenosVendidos();
                    break;
                case 2:
                    MostrarProductosMasRentables();
                    break;
            }
        }
    }
}
