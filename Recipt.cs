using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;


namespace group28_1
{
    public partial class Recipt : Form
    {
        /*private Event v;
        private Customer c;
        private string total;
        private string bid;*/
        public Recipt(string eventid, string customerid, string total, string bid)
        {
            InitializeComponent();
            Event v = Program.seek_event(eventid);
            Customer c = Program.seekCustomer(long.Parse(customerid));
            customerName.Text = c.get_firstName() + " " + c.get_lastName();
            Bid_id.Text = bid;
            DateTime currentTime = DateTime.Now;
            date.Text = currentTime.ToString("dd-MM-yyyy");
            customer_ID.Text = c.get_id().ToString();
            customerEmail.Text = c.get_email();
            customerPhone.Text = c.get_phoneNumber();
            event_ID.Text = v.get_eventID();
            eventType.Text = v.get_type().ToString();
            eventDate.Text = v.get_date().ToString("dd-MM-yyyy");
            totalPrice.Text = total;
            design_Price();
            this.Show();
            //priceLabel.Hide();
            //totalPrice.Hide();
            send_Recipt();
            this.Hide();
        }
        private void Recipt_Load(object sender, EventArgs e)
        {

        }
        private void design_Price()
        {
            foreach (Design_event de in Program.all_design_event)
            {
                if (de.get_eventID().ToString() == event_ID.Text)//must
                {
                    foreach (Design d in Program.Designs)
                    {
                        if (de.get_designID() == d.get_DesignID())//must
                        {
                            dataGridView1.Rows.Add(d.get_DesignID(), d.get_price());
                        }
                    }
                }
            }
        }
        private void send_Recipt()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Create a Bitmap object to hold the screen capture
                    using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
                    {
                        // Create a Graphics object to draw on the bitmap
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            // Draw the screen capture to the bitmap
                            this.DrawToBitmap(bitmap, new Rectangle(5, 5, this.Width, this.Height));

                            // Save the bitmap as a JPEG file
                            bitmap.Save(sfd.FileName, ImageFormat.Jpeg);

                            // Create a memory stream to hold the JPEG file
                            using (MemoryStream stream = new MemoryStream())
                            {
                                // Save the JPEG file to the memory stream
                                bitmap.Save(stream, ImageFormat.Jpeg);

                                // Reset the position of the stream to the beginning
                                stream.Position = 0;

                                // Create an attachment from the memory stream
                                Attachment attachment = new Attachment(stream, "screen_capture.jpeg", "application/Jpeg");

                                // Send the email with the attachment
                                //Program.SendMail("smtp.gmail.com", 587, "aleydafna23@gmail.com", "kwqyvftkdneljgvr", "stavb96@gmail.com", "AleyDafna purchase approval confirmation", null, attachment);
                                Program.SendMail("smtp.gmail.com", 587, "yahalthaen@gmail.com", "drclsgudwhkppsez", "atanelov@post.bgu.ac.il", "Yahalt Haen bid approval confirmation", null, attachment);
                            }
                        }
                    }
                }
            }
        }
    }
}
