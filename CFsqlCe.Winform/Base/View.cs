using System;
using System.Drawing;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Base
{
    public class View : DataGridView
    {
        public event EventHandler Deleting;        

        public View()
        {
            //this.RowHeadersVisible = false;
            //this.AllowUserToAddRows = false;
            //this.AllowUserToDeleteRows = false;
            //this.ReadOnly = true;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;            
            this.CellPainting += dataGridView1_CellPainting;
            this.CellClick += View_CellClick;
            
        }

        void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex == -1) return;
            if (this.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show(this.Parent, "Tem certeza?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(Deleting != null) Deleting(this, null);
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex == -1) return;
            
            switch (this.Columns[e.ColumnIndex].Name)
            {
                case "colDelete":
                    drawImage(MyImages.FlatIcons(MyImages.Code.del), e);
                    break;
                case "colEdit":
                    drawImage(MyImages.FlatIcons(MyImages.Code.edit), e);
                    break;
                case "colFolder":
                    drawImage(MyImages.FlatIcons(MyImages.Code.folder), e);
                    break;
                case "colOk":
                    drawImage(MyImages.FlatIcons(MyImages.Code.ok), e);
                    break;
                case "colChart":
                    drawImage(MyImages.FlatIcons(MyImages.Code.chart), e);
                    break;
            }
        }

        private static Image drawImage(Image img, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            e.Graphics.DrawImage(img, (int)((e.CellBounds.Width / 2) - (img.Width / 2)) + e.CellBounds.X, (int)((e.CellBounds.Height / 2) - (img.Height / 2)) + e.CellBounds.Y);
            e.Handled = true;
            return img;
        }
    }
}
