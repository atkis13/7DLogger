using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Windows.Forms;

namespace _7DLogger
{
    class Form_methods
    {
        public static void CreateNewLog(string date, string content, string type)
        {
            string name = "";
            string po = "";
            if (type == "main")
            {
                name = "Main.pdf";
                po = date + "Main Log Created";
            }
            else if(type == "toDo")
            {
                name = "todo.pdf";
                po = date;
            }
            else if(type == "done")
            {
                name = "done.pdf";
                po = date;
            }

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(name, FileMode.Create));
            doc.Open();
            Paragraph p0 = new Paragraph(po);
            Paragraph p1 = new Paragraph(" ");
            Paragraph p2 = new Paragraph(content);
            Paragraph p3 = new Paragraph("=============================================");
            doc.Add(p0);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Close();
        }


        public static void EditLog(string date, string previous, string current)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Main.pdf", FileMode.Create));
            doc.Open();
            Paragraph p0 = new Paragraph(previous);
            Paragraph p1 = new Paragraph(" ");
            Paragraph p2 = new Paragraph(date);
            Paragraph p3 = new Paragraph(" ");
            Paragraph p4 = new Paragraph(current);
            Paragraph p5 = new Paragraph("=============================================");
            doc.Add(p0);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Close();
        }

        public static void ReadPDFLog(string type, RichTextBox rt)
        {
            string strx = string.Empty;
            string name = "";
            if(type == "toDo")
            {
                name = "todo.pdf";
            }
            else if(type == "done")
            {
                name = "done.pdf";
            }
           
            try
            {
                //adding the pdf to the rich text box
                PdfReader reader = new PdfReader(name);
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strx = strx + s;
                    rt.Text = strx;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static string Mainlog()
        {
            string strx = string.Empty;
            string main = "";
            try
            {
                //adding the pdf to the rich text box
                PdfReader reader = new PdfReader("main.pdf");
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strx = strx + s;
                    
                   
                }
                main = strx;
                reader.Close();       
                

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return main;
        }


        public static void addImgPicbox(Label txt)
        {
            string path = txt.Text;
            string dest = Application.StartupPath + @"\\images\\img.jpg";
            try
            {
                System.IO.File.Copy(path, dest, true);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void selectImg(Label txt, PictureBox pic)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG Files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                string picloc = op.FileName.ToString();
                txt.Text = picloc;
                pic.ImageLocation = picloc;
            }
        }


    }
}
