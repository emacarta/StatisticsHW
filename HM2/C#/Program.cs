using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

class DrawingForm : Form
{
    public DrawingForm()
    {
        // Imposta le dimensioni della finestra
        this.Size = new Size(400, 400);

        // Registra l'evento Paint
        this.Paint += new PaintEventHandler(DrawingForm_Paint);
    }

    private void DrawingForm_Paint(object sender, PaintEventArgs e)
    {
        // Crea un oggetto Graphics per disegnare sulla finestra
        Graphics g = e.Graphics;

        // Crea una penna e un pennello
        Pen pen = new Pen(Color.Black, 2);
        SolidBrush brush = new SolidBrush(Color.Red);

        // Disegna una linea
        g.DrawLine(pen, 50, 50, 200, 50);

        // Disegna un quadrato
        g.DrawRectangle(pen, 50, 100, 100, 100);

        // Disegna un cerchio
        g.DrawEllipse(pen, 50, 250, 100, 100);

        // Disegna un punto
        g.FillEllipse(brush, 200, 200, 5, 5);

        // Rilascia le risorse
        pen.Dispose();
        brush.Dispose();
    }

    static void Main()
    {
        Application.Run(new DrawingForm());
    }
}
