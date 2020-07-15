using System;
using System.IO;
using iText.Kernel.Pdf;

namespace example_1 
{
    public class RemoveOneOutline {
        public const String DEST = "../../results/removedOutlinePdf.pdf";

        public static void Main(String[] args)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();
            new RemoveOneOutline().RemoveOneOutlineSubtree(DEST);
        }
        public virtual void RemoveOneOutlineSubtree(String DEST)
        {
            String input = sourceFolder + "my_output_pdf.pdf";
            PdfReader reader = new PdfReader(input);
            PdfWriter writer = new PdfWriter(DEST);
            PdfDocument pdfDocument = new PdfDocument(reader, writer);
            PdfOutline root = pdfDocument.GetOutlines(true);
            PdfOutline toRemove = root.GetAllChildren().Get(0);
            toRemove.RemoveOutline();
            pdfDocument.Close();
        }
    }
}