using System;
using System.IO;
using iText.Kernel.Pdf;

namespace example_2
{
    public class RemoveAllOutlines {
        public const String DEST = "../../results/removedAllutlinePdf.pdf";

        public static void Main(String[] args)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();
            new RemoveAllOutlines().RemoveWholeOutlineSubtree(DEST);
        }
        public virtual void RemoveWholeOutlineSubtree(String DEST)
        {
            String input = sourceFolder + "my_output_pdf.pdf";
            PdfReader reader = new PdfReader(input);
            PdfWriter writer = new PdfWriter(DEST);
            PdfDocument pdfDocument = new PdfDocument(reader, writer);
            pdfDocument.GetOutlines(true).RemoveOutline();
            pdfDocument.Close();
            pdfDocument.Close();
        }
    }
}