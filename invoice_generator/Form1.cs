using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using ZXing;
namespace invoice_generator
{
    public partial class Form1 : Form
    {
       private double grandTotal = 0; // Variable to store the sum of "Total" column
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize DataGridView with columns
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("CustomerName", "Customer Name");
            dataGridView1.Columns.Add("CustomerMobile", "Customer Mobile Number");
            dataGridView1.Columns.Add("Products", "Products");
            dataGridView1.Columns.Add("Quentity", "Quentity");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Total", "Total");
        }
        private void adding(string customerName, string customerMobile, string product, string quentity, string price)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = customerName;
            row.Cells[1].Value = customerMobile;
            row.Cells[2].Value = product;
            row.Cells[3].Value = quentity;
            row.Cells[4].Value = price;
            double quentityValue = double.Parse(quentity);
            double priceValue = double.Parse(price);

            row.Cells[5].Value = quentityValue * priceValue;
            dataGridView1.Rows.Add(row);
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cnm.Text) == true)
            {
                cnm.Focus();
                errorProvider1.SetError(this.cnm, "Please Fill Name");
            }
            else if (string.IsNullOrEmpty(cmo.Text) == true)
            {
                cmo.Focus();
                errorProvider2.SetError(this.cnm, "Please Fill Mobile no");
            }
            else if (string.IsNullOrEmpty(quentity.Text) == true)
            {
                quentity.Focus();
                errorProvider3.SetError(this.quentity, "Please Fill Quentity");
            }
            else if (string.IsNullOrEmpty(price.Text) == true)
            {
                price.Focus();
                errorProvider4.SetError(this.price, "Please Fill Price");
            }
            else
            {
                adding(cnm.Text, cmo.Text, product.Text, quentity.Text, price.Text);
            }
            quentity.Text = "";
            price.Text = "";
        }
        private void cmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnm_TextChanged(object sender, EventArgs e)
        {

        }
        private void product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }
        public void numeric(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void alpha(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void quentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void quentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }

        private void cnm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cnm.Text) == true)
            {
                cnm.Focus();
                errorProvider1.SetError(this.cnm, "Please Fill Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cmo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmo.Text) == true)
            {
                cmo.Focus();
                errorProvider2.SetError(this.cmo, "Please Fill Mobile no");
            }
            else if (cmo.Text.Length != 10)
            {
                cmo.Focus();
                errorProvider2.SetError(this.cmo, "Please Enter 10 Digit");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void quentity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quentity.Text) == true)
            {
                quentity.Focus();
                errorProvider3.SetError(this.quentity, "Please Fill Quentity");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void price_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(price.Text) == true)
            {
                price.Focus();
                errorProvider4.SetError(this.price, "Please Fill Price");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Invoice.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, memoryStream);

                            document.Open();

                            Paragraph title = new Paragraph("Invoice", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24f, iTextSharp.text.Font.BOLD));
                            title.Alignment = Element.ALIGN_CENTER;
                            document.Add(title);
                            // Add customer name and mobile number
                            document.Add(new Paragraph("\n"));

                            Paragraph customerInfo = new Paragraph($"Customer Name: {cnm.Text}\nMobile Number: {cmo.Text}\n\n");
                            customerInfo.Alignment = Element.ALIGN_LEFT;
                            document.Add(customerInfo);

                            document.Add(new Paragraph("\n"));

                            Paragraph creationDateParagraph = new Paragraph($"Invoice Creation Date And Time: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
                            creationDateParagraph.Alignment = Element.ALIGN_RIGHT;
                            document.Add(creationDateParagraph);
                            // Add title to the PDF

                            // Add space between title and table
                            document.Add(new Paragraph("\n"));

                            // Add title to the PDF
                            PdfPTable ptable = new PdfPTable(dataGridView1.Columns.Count - 2); // Subtract 2 for the first two columns
                            ptable.DefaultCell.Padding = 4;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            for (int i = 2; i < dataGridView1.Columns.Count; i++)  // Skip first 2 columns
                            {
                                DataGridViewColumn col = dataGridView1.Columns[i];
                                PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText ?? ""));
                                ptable.AddCell(pcell);
                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                for (int i = 2; i < dataGridView1.Columns.Count; i++)  // Skip first 2 columns
                                {
                                    DataGridViewCell dcell = viewRow.Cells[i];
                                    string cellStringValue = dcell.Value?.ToString() ?? "";
                                    ptable.AddCell(cellStringValue);

                                    // Check if the current cell belongs to the "Total" column
                                    if (dcell.OwningColumn.Name == "Total")
                                    {
                                        if (double.TryParse(cellStringValue, out double cellValue))
                                        {
                                            grandTotal += cellValue; // Add the value to the grand total
                                        }
                                    }
                                }
                            }
                            document.Add(ptable);
                            // Add space between table and Grand Total
                            document.Add(new Paragraph("\n"));

                            // Add Grand Total to the PDF
                            Paragraph grandTotalParagraph = new Paragraph($"Grand Total: {grandTotal}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD));
                            grandTotalParagraph.Alignment = Element.ALIGN_RIGHT;
                            document.Add(grandTotalParagraph);

                            document.Close();

                            // Save the content of the memory stream to a file
                            File.WriteAllBytes(save.FileName, memoryStream.ToArray());
                        }

                        MessageBox.Show("Data Export Successful", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error While Exporting Data" + ex.Message, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void DirectPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;
            DialogResult result=printdialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Font for the content
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
            System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 12);

            // Display Invoice title in the center and at the top
            string invoiceTitle = "Invoice";
            SizeF titleSize = e.Graphics.MeasureString(invoiceTitle, titleFont);
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(invoiceTitle, titleFont, Brushes.Black, new PointF(titleX, y));

            // Move to the next line after the title
            y += titleSize.Height + 20;

            // Display Invoice Number
            string invoiceNumber = "12345"; // Replace with actual invoice number
            e.Graphics.DrawString($"Invoice Number: {invoiceNumber}", contentFont, Brushes.Black, new PointF(x, y));

            // Move to the next line
            y += 20;

            // Display customer name and mobile number
            e.Graphics.DrawString($"Customer Name: {cnm.Text}\nMobile Number: {cmo.Text} \n \n", contentFont, Brushes.Black, new PointF(x, y));

            // Move to the next line
            y += 20;

            // Set top margin for DataGridView columns
            float originalX = x; // Store the original X position for resetting later
            y += 20;

            // Display DataGridView columns
            for (int i = 2; i < dataGridView1.Columns.Count; i++)
            {
                float colWidth = e.Graphics.MeasureString(dataGridView1.Columns[i].HeaderText, contentFont).Width;
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, contentFont, Brushes.Black, new PointF(x, y));

                // Move to the next column position
                x += colWidth + 20;
            }

            // Reset X position for data rows
            x = originalX;

            // Move to the next line
            y += 20;

            // Display DataGridView content
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 2; i < dataGridView1.Columns.Count; i++)
                {
                    float colWidth = e.Graphics.MeasureString(row.Cells[i].Value?.ToString() ?? "", contentFont).Width;
                    e.Graphics.DrawString(row.Cells[i].Value?.ToString() ?? "", contentFont, Brushes.Black, new PointF(x, y));

                    // Move to the next column position
                    x += colWidth + 58;
                }

                // Reset X position for the next row
                x = originalX;

                // Move to the next line
                y += 20;
            }

            // Calculate Grand Total outside the loop
            double grandTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (double.TryParse(row.Cells["Total"].Value?.ToString() ?? "", out double cellValue))
                {
                    grandTotal += cellValue; // Add the value to the grand total
                }
            }

            // Move to the next line
            y += 20;

            // Display Grand Total
            e.Graphics.DrawString($"Grand Total: {grandTotal}", contentFont, Brushes.Black, new PointF(e.MarginBounds.Left, y));

            // Move to the next line
            y += 20;

            // Generate and display QR code for the invoice number
            var qrCode = GenerateQRCode(invoiceNumber);
            e.Graphics.DrawImage(qrCode, x, y);

            // Example method to generate QR code using ZXing library
            System.Drawing.Image GenerateQRCode(string data)
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options = new ZXing.Common.EncodingOptions
                {
                    Width = 100, // Adjust the width as needed
                    Height = 100, // Adjust the height as needed
                };

                Bitmap qrCodeBitmap = barcodeWriter.Write(data);
                return qrCodeBitmap;
            }
        }

        private void cnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            alpha(sender, e);
        }
    }
}