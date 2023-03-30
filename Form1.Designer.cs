namespace AynıZamanlıUretim
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnUret = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSkor = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMayın = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUret
			// 
			resources.ApplyResources(this.btnUret, "btnUret");
			this.btnUret.Name = "btnUret";
			this.btnUret.UseVisualStyleBackColor = true;
			this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
			// 
			// flowLayoutPanel1
			// 
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// lblSkor
			// 
			resources.ApplyResources(this.lblSkor, "lblSkor");
			this.lblSkor.Name = "lblSkor";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// lblMayın
			// 
			resources.ApplyResources(this.lblMayın, "lblMayın");
			this.lblMayın.Name = "lblMayın";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblMayın);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSkor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.btnUret);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUret;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSkor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblMayın;
	}
}

