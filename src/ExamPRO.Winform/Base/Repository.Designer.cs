namespace ExamPro.Winform.Base
{
    partial class Repository
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repository));
            this.flatIcons = new System.Windows.Forms.ImageList(this.components);
            this.menuIcons = new System.Windows.Forms.ImageList(this.components);
            this.femaieMale32 = new System.Windows.Forms.ImageList(this.components);
            // 
            // flatIcons
            // 
            this.flatIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("flatIcons.ImageStream")));
            this.flatIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.flatIcons.Images.SetKeyName(0, "add.png");
            this.flatIcons.Images.SetKeyName(1, "chart.png");
            this.flatIcons.Images.SetKeyName(2, "del.png");
            this.flatIcons.Images.SetKeyName(3, "edit.png");
            this.flatIcons.Images.SetKeyName(4, "folder.png");
            this.flatIcons.Images.SetKeyName(5, "info.png");
            this.flatIcons.Images.SetKeyName(6, "search.png");
            this.flatIcons.Images.SetKeyName(7, "ok.png");
            // 
            // menuIcons
            // 
            this.menuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIcons.ImageStream")));
            this.menuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIcons.Images.SetKeyName(0, "patient-2-icon.png");
            this.menuIcons.Images.SetKeyName(1, "lab-icon.png");
            this.menuIcons.Images.SetKeyName(2, "graph.png");
            this.menuIcons.Images.SetKeyName(3, "close-icon.png");
            // 
            // femaieMale32
            // 
            this.femaieMale32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("femaieMale32.ImageStream")));
            this.femaieMale32.TransparentColor = System.Drawing.Color.Transparent;
            this.femaieMale32.Images.SetKeyName(0, "female.png");
            this.femaieMale32.Images.SetKeyName(1, "male.png");

        }

        #endregion

        internal System.Windows.Forms.ImageList menuIcons;
        internal System.Windows.Forms.ImageList flatIcons;
        internal System.Windows.Forms.ImageList femaieMale32;



    }
}
