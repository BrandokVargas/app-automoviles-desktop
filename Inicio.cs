using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Aplicativo_Automóviles
{
    public partial class Inicio : Form
    {
        private string user;
        Bicola bi = new Bicola();
        Arbol a = new Arbol();

        public Inicio(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            a.Insertar(ref a.raiz, new Autos(Convert.ToInt32(txtPlaca.Text), txtMarca.Text,txtModelo.Text,txtColor.Text));
            MostraArbol();


            dgvLista.Columns.Clear();
            a.PreOrden(a.raiz, dgvLista);


        
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtSaludar.Text += user;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            Login l = new Login();
            l.ShowDialog();

        }
        public void MostraArbol()
        {
            Autos[] L = new Autos[20];
            int[] p = new int[50];
            int ce = 0;
            dgvArbol.Columns.Clear();
            a.verArbol(a.raiz, L, p, 0, ref ce);
            for (int i = 0; i < ce; i++) dgvArbol.Columns.Add("", "");
            for (int i = 0; i < ce; i++) dgvArbol.Rows.Add();
            for (int i = 0; i < ce; i++) dgvArbol[i, p[i]].Value = "AN - " + L[i].placa;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = a.Altura(a.raiz);
            MessageBox.Show("La altura del árbol es: " + altura);
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            int peso = a.Peso(a.raiz);
            MessageBox.Show("El peso del árbol es: " + peso);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int placa = Convert.ToInt32(txtPlacaBus.Text);
            Autos encontrado = a.Buscar(a.raiz, placa);
            if (encontrado != null)
            {
                MessageBox.Show("Placa encontrada: " + encontrado.ToString());
            }
            else
            {
                MessageBox.Show("Esta placa no se encuentra dentro del sistema");
            }
        }

        private void btnBicola_Click(object sender, EventArgs e)
        {
            bi = new Bicola();
            a.UnirBicolaArbol(a.raiz,bi);
            dgvBicolaOrdenado.Rows.Clear();
            bi.Ordenamiento();
            bi.MostrarDI(dgvBicolaOrdenado);

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dgvOrdenado.Columns.Clear();
            a.Invertir(a.raiz, dgvOrdenado);

            //a.Invertir(a.raiz, dgvOrdenado);


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog reporte = new SaveFileDialog();
            
            reporte.FileName =  "resporte" + ".pdf";
            reporte.ShowDialog();

            string reportePDF = Properties.Resources.reporte.ToString();

            reportePDF = reportePDF.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvBicolaOrdenado.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["PLACA"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["MARCA"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["MODELO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["COLOR"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            reportePDF = reportePDF.Replace("@FILAS",filas);



            if (reporte.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(reporte.FileName, FileMode.Create))
                {
                    
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //LOGO
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Parquin, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    
                    using (StringReader sr = new StringReader(reportePDF))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }




        }
    }
}
