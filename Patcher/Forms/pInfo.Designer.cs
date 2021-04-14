
namespace FX.Patcher
{
    partial class pInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1-) Priest sınıfı skill atarken (db, malice, torment, massive) karakterin üstünde" +
                " attığı skilin ismi yazar. Örnek \"Malice Atıyor\" şeklinde.",
            "",
            "2-) Db, malice, massive skillerinden birisini yiyen karakterin kafasında yediği s" +
                "kilin beceri ikonu çıkar ve belli bir saniye kalır.",
            "",
            "3-) Minor, lightfeet, stealth skillerinin efektleri kaldırılmıştır.",
            "",
            "4-) Magelerin tüm efektleri kaldırılmış ve sadece nova(60) skillerinin efektleri " +
                "vardır. Eğer magede efekt çıkarsa nova atıyor demektir.",
            "",
            "5-) Efekt fazlalığı olmasın diye nova(60) skillerinin efektleri 45 skillerinin ef" +
                "ektleri ile değiştirilmiştir.",
            "",
            "6-) Priestlerin heal kısmında 10k ve 1920 skilleri harici efektler silinmiştir.",
            "",
            "7-) 10k ve 1920 heallerin efektleri değiştirilmiştir. Hafif hale getirildi.",
            "",
            "8-) Pot ve mana basınca çıkan efektler hafifleştirilmiştir.",
            "",
            "9-) Priestlerin restora efektleri kaldırılmıştır.",
            "",
            "10-) Magelerin 33 ve 45 alan skilleri gözükmez. Nova(60) vurunca yerden gözükür.",
            "",
            "11-) Warrior yere vurma efektleri kaldırılmıştır.",
            "",
            "12-) Yeni obje eklenmiştir. Ardream ve cz de ağaç yapraklı yoktur.",
            "        Bazı yerlede ağaçlar gözükmüyor onlar fixlenmiştir artık orada bir şey ol" +
                "duğu gösteren obje eklenmiştir."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(628, 329);
            this.listBox1.TabIndex = 0;
            // 
            // pInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 348);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pInfo";
            this.Text = "Bilgi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}