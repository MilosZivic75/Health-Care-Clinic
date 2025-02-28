﻿using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Pharmacy.Service
{
    public class PrescriptionService : IPrescriptionService
    {
        public void UploadPdf(Bitmap qr)
        {
            qr.Save("image.bmp");
            System.Drawing.Image image = System.Drawing.Image.FromFile("image.bmp");
            Document doc = new Document(PageSize.A4);
            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream("image.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(qr, System.Drawing.Imaging.ImageFormat.Bmp);
            doc.Add(pdfImage);
            doc.Close();
        }
    }
}
