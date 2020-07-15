package support.JiraArticles;

import com.itextpdf.kernel.pdf.PdfDocument;
import com.itextpdf.kernel.pdf.PdfOutline;
import com.itextpdf.kernel.pdf.PdfReader;
import com.itextpdf.kernel.pdf.PdfWriter;

import java.io.File;
import java.io.IOException;


public class removeOneOutline {

    public static final String DEST = "results/outlinechanged.pdf";

    public static void main(String[] args) throws IOException {
        File file = new File(DEST);
        file.getParentFile().mkdirs();
        new removeOneOutline().removeOneOutline(DEST);
    }

    public void removeOneOutline(String DEST) throws IOException {
        String input = "resources/example_document_2.pdf";
        PdfReader reader = new PdfReader(input);
        PdfWriter writer = new PdfWriter(DEST);
        PdfDocument pdfDocument = new PdfDocument(reader, writer);
        PdfOutline root = pdfDocument.getOutlines(true);
        PdfOutline toRemove = root.getAllChildren().get(0);
        toRemove.removeOutline();
        pdfDocument.close();
    }
}


