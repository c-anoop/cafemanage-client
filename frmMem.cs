using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using clsLibIsNum.tmpComp; 
namespace Client
{
	/// <summary>
	/// Summary description for frmMem.
	/// </summary>
	public class frmMem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		protected System.Windows.Forms.TextBox txtFavour;
		protected System.Windows.Forms.TextBox txtSite;
		protected System.Windows.Forms.TextBox txtID;
		protected System.Windows.Forms.TextBox txtAdd;
		protected System.Windows.Forms.TextBox txtParent;
		protected System.Windows.Forms.TextBox txtName;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.TextBox txtPassCode;
		protected System.Windows.Forms.TextBox txtAmtPaid;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		protected System.Windows.Forms.TextBox txtUsrId;
		protected System.Windows.Forms.TextBox txtConfirmPassCode;
		private System.ComponentModel.IContainer components;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Client.dsMemb dsMemb1;
		private string tempPath=frmClient.serverDatabasePath + @"\member.mdb" ;
		private int recordNo;
		
		public frmMem(int recNo1)
		{
			//
			// Required for Windows Form Designer support
			//
			
			InitializeComponent();
			// oleDbConnection1
			// 
			string [] array1 = new string[2];
			array1= tempPath.Split(new char[]{':'},2);
 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=\\" + frmClient.serverName +  @"\" + frmClient.serverShare + array1[1] + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1

			//
			// TO DO: Add any constructor code after Initialize Component call
			//

			//oleDbConnection
			recordNo=recNo1;
			dsMemb1.Clear();
			oleDbDataAdapter1.Fill (dsMemb1);
			

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMem));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtAmtPaid = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtConfirmPassCode = new System.Windows.Forms.TextBox();
			this.txtPassCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUsrId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFavour = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtSite = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtParent = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsMemb1 = new Client.dsMemb();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsMemb1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.btnOk,
																					this.label12,
																					this.label11,
																					this.txtAmtPaid,
																					this.label10,
																					this.txtConfirmPassCode,
																					this.txtPassCode,
																					this.label9,
																					this.label8,
																					this.txtUsrId,
																					this.label7,
																					this.txtFavour,
																					this.label6,
																					this.btnCancel,
																					this.txtSite,
																					this.label5,
																					this.txtID,
																					this.label4,
																					this.txtAdd,
																					this.label3,
																					this.label2,
																					this.txtParent,
																					this.txtName,
																					this.label1});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 424);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Member Information :";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnOk
			// 
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(168, 392);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "&OK";
			this.toolTip1.SetToolTip(this.btnOk, "Save Changes");
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(227, 190);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 24);
			this.label12.TabIndex = 23;
			this.label12.Text = "/-";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(152, 191);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 24);
			this.label11.TabIndex = 22;
			this.label11.Text = "Rs.";
			// 
			// txtAmtPaid
			// 
			this.txtAmtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmtPaid.Enabled = false;
			this.txtAmtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAmtPaid.Location = new System.Drawing.Point(176, 184);
			this.txtAmtPaid.Name = "txtAmtPaid";
			this.txtAmtPaid.Size = new System.Drawing.Size(48, 20);
			this.txtAmtPaid.TabIndex = 5;
			this.txtAmtPaid.Text = "";
			this.txtAmtPaid.TextChanged += new System.EventHandler(this.txtAmtPaid_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "Amount Paid          :";
			// 
			// txtConfirmPassCode
			// 
			this.txtConfirmPassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtConfirmPassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtConfirmPassCode.Location = new System.Drawing.Point(152, 120);
			this.txtConfirmPassCode.Name = "txtConfirmPassCode";
			this.txtConfirmPassCode.PasswordChar = '*';
			this.txtConfirmPassCode.Size = new System.Drawing.Size(128, 22);
			this.txtConfirmPassCode.TabIndex = 3;
			this.txtConfirmPassCode.Text = "";
			this.txtConfirmPassCode.TextChanged += new System.EventHandler(this.txtConfirmPassCode_TextChanged);
			// 
			// txtPassCode
			// 
			this.txtPassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPassCode.Location = new System.Drawing.Point(152, 88);
			this.txtPassCode.Name = "txtPassCode";
			this.txtPassCode.PasswordChar = '*';
			this.txtPassCode.Size = new System.Drawing.Size(128, 22);
			this.txtPassCode.TabIndex = 2;
			this.txtPassCode.Text = "";
			this.txtPassCode.TextChanged += new System.EventHandler(this.txtPassCode_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Confirm PassCode  :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "PassCode              : ";
			// 
			// txtUsrId
			// 
			this.txtUsrId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsrId.Enabled = false;
			this.txtUsrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUsrId.Location = new System.Drawing.Point(152, 56);
			this.txtUsrId.Name = "txtUsrId";
			this.txtUsrId.Size = new System.Drawing.Size(128, 20);
			this.txtUsrId.TabIndex = 1;
			this.txtUsrId.Text = "";
			this.txtUsrId.TextChanged += new System.EventHandler(this.txtUsrId_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "User ID                  : ";
			// 
			// txtFavour
			// 
			this.txtFavour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFavour.Location = new System.Drawing.Point(152, 328);
			this.txtFavour.Multiline = true;
			this.txtFavour.Name = "txtFavour";
			this.txtFavour.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFavour.Size = new System.Drawing.Size(192, 40);
			this.txtFavour.TabIndex = 9;
			this.txtFavour.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Favourite Sites       :";
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(256, 392);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.btnCancel, "Quits Window");
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtSite
			// 
			this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSite.Location = new System.Drawing.Point(252, 296);
			this.txtSite.Name = "txtSite";
			this.txtSite.Size = new System.Drawing.Size(72, 20);
			this.txtSite.TabIndex = 8;
			this.txtSite.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(232, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "@";
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtID.Location = new System.Drawing.Point(152, 296);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(80, 20);
			this.txtID.TabIndex = 7;
			this.txtID.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "E-Mail ID                :";
			// 
			// txtAdd
			// 
			this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdd.Location = new System.Drawing.Point(152, 216);
			this.txtAdd.Multiline = true;
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAdd.Size = new System.Drawing.Size(128, 64);
			this.txtAdd.TabIndex = 6;
			this.txtAdd.Text = "";
			this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Parentage              :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Address                  :";
			// 
			// txtParent
			// 
			this.txtParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtParent.Enabled = false;
			this.txtParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtParent.Location = new System.Drawing.Point(152, 152);
			this.txtParent.Name = "txtParent";
			this.txtParent.Size = new System.Drawing.Size(128, 20);
			this.txtParent.TabIndex = 4;
			this.txtParent.Text = "";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Enabled = false;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtName.Location = new System.Drawing.Point(152, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name                     :";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "member", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("Name", "Name"),
																																																				  new System.Data.Common.DataColumnMapping("User ID", "User ID"),
																																																				  new System.Data.Common.DataColumnMapping("Parentage", "Parentage"),
																																																				  new System.Data.Common.DataColumnMapping("Total Time Alloted", "Total Time Alloted"),
																																																				  new System.Data.Common.DataColumnMapping("Balanced Time", "Balanced Time"),
																																																				  new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				  new System.Data.Common.DataColumnMapping("E-Mail ID", "E-Mail ID"),
																																																				  new System.Data.Common.DataColumnMapping("Favourite Sites", "Favourite Sites"),
																																																				  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																				  new System.Data.Common.DataColumnMapping("Amount", "Amount"),
																																																				  new System.Data.Common.DataColumnMapping("PassCode", "PassCode"),
																																																				  new System.Data.Common.DataColumnMapping("Date", "Date")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM member WHERE (ID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Balanced Time] = ? OR ? IS NULL AND [Balanced Time] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND ([Favourite Sites] = ? OR ? IS NULL AND [Favourite Sites] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Parentage = ? OR ? IS NULL AND Parentage IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND ([Total Time Alloted] = ? OR ? IS NULL AND [Total Time Alloted] IS NULL) AND ([User ID] = ? OR ? IS NULL AND [User ID] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			// 
			
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO member(Address, Amount, [Balanced Time], [Date], [E-Mail ID], [Favour" +
				"ite Sites], ID, Name, Parentage, PassCode, [Total Time Alloted], [User ID]) VALU" +
				"ES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, "Favourite Sites"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, "Parentage"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Address, Amount, [Balanced Time], [Date], [E-Mail ID], [Favourite Sites], " +
				"ID, Name, Parentage, PassCode, [Total Time Alloted], [User ID] FROM member";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE member SET Address = ?, Amount = ?, [Balanced Time] = ?, [Date] = ?, [E-Mail ID] = ?, [Favourite Sites] = ?, ID = ?, Name = ?, Parentage = ?, PassCode = ?, [Total Time Alloted] = ?, [User ID] = ? WHERE (ID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Balanced Time] = ? OR ? IS NULL AND [Balanced Time] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND ([Favourite Sites] = ? OR ? IS NULL AND [Favourite Sites] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Parentage = ? OR ? IS NULL AND Parentage IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND ([Total Time Alloted] = ? OR ? IS NULL AND [Total Time Alloted] IS NULL) AND ([User ID] = ? OR ? IS NULL AND [User ID] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, "Favourite Sites"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, "Parentage"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			// 
			// dsMemb1
			// 
			this.dsMemb1.DataSetName = "dsMemb";
			this.dsMemb1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsMemb1.Namespace = "http://www.tempuri.org/dsMemb.xsd";
			// 
			// frmMem
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(374, 432);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " New Member";
			this.Load += new System.EventHandler(this.frmMem_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsMemb1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		     
			this.Close ();

		}

		protected virtual void btnOk_Click(object sender, System.EventArgs e)
		{   

       			bool boolTemp;
			boolTemp=Validation();

			if (boolTemp==true)
				return;
			MessageBoxButtons Button = MessageBoxButtons.YesNo ;
			DialogResult result=MessageBox.Show(this,"Confirm Addition","Warning",Button,MessageBoxIcon.Exclamation);
			if(result==DialogResult.No) return;
             
//		
			
			dsMemb1.Tables[0].Rows[recordNo]["Amount"] =this.txtAmtPaid.Text;
			
			dsMemb1.Tables[0].Rows[recordNo]["Address"] =this.txtAdd .Text;
			dsMemb1.Tables[0].Rows[recordNo]["PassCode"]=this.txtPassCode.Text ;
			dsMemb1.Tables[0].Rows[recordNo]["Favourite Sites"]=this.txtFavour.Text;
			dsMemb1.Tables[0].Rows[recordNo]["E-Mail Id"] =this.txtID .Text+"@" +this.txtSite.Text ;
			dsMemb1.Tables[0].Rows[recordNo]["PassCode"]= this.txtConfirmPassCode .Text ;
//			DataRow anyRow = dsMemb1.member.NewRow();
//
//			// ID(Primary Key) as Autonumber
//			if (dsMemb1.Tables[0].Rows.Count==0)
//			{
//				anyRow["ID"]="Member-" + 1;
//			}
//			else
//			{
//				for (int i=1;i<=dsMemb1.Tables[0].Rows.Count+1;i++)
//				{
//					DataView dtvTemp = new DataView(dsMemb1.Tables[0] ,"","ID",DataViewRowState.CurrentRows );
//					int intTemp1 = dtvTemp.Find("Member-" + i.ToString());
//					if (intTemp1!=-1)
//					{
//						continue;
//					}
//					else
//					{
//						anyRow["ID"]="Member-" + i.ToString();
//						break;
//					}
//				}
//	
//			}
//
//			
//			anyRow["Name"]  = txtName.Text;
//			anyRow["User ID"] = txtUsrId.Text;
//			anyRow["Parentage"] = txtParent.Text;
//			anyRow["Total Time Alloted"] = 1;
//			anyRow["Balanced Time"] = 2;
//			anyRow["Address"] = txtAdd.Text;
//			anyRow["E-Mail ID"]=txtID.Text + "@" + txtSite.Text;
//			anyRow["Favourite Sites"] = txtFavour.Text;
//			anyRow["Amount"] = txtAmtPaid.Text;
//			anyRow["PassCode"] = txtPassCode.Text;
//			anyRow["Date"] = DateTime.Today;	
//			dsMemb1.member.Rows.Add(anyRow);
//			
			DataRow[] myDataRowArray = dsMemb1.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent);
			oleDbDataAdapter1.Update(myDataRowArray);
//			this.btnAdd.Visible = true;
//			this.btnOk.Visible = false;
		}
		
		private bool Validation()
		{
			bool boolTemp=false;
			//
			// This part checks the proper entry of the Record
			// 
			if (txtName.Text=="")
			{  
				boolTemp=true;
				label1.ForeColor =Color.Red;
			}
			if (txtAmtPaid.Text=="")
			{
				label10.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtAdd.Text=="") 
			{
				label2.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtPassCode.Text=="")
			{
				label8.ForeColor =Color.Red;
				boolTemp=true;
			}
			if (txtUsrId.Text=="")
			{
				label7.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtConfirmPassCode.Text=="")
			{
				label9.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (boolTemp==true)
			{
				MessageBox.Show("Fields in Red are needed","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning );
				boolTemp=false;
				if(label2.ForeColor==Color.Red)  txtAdd.Focus();
				if(label10.ForeColor==Color.Red)  txtAmtPaid.Focus();
				if(label9.ForeColor==Color.Red)  txtConfirmPassCode.Focus();
				if(label8.ForeColor==Color.Red)  txtPassCode.Focus();
				if(label7.ForeColor==Color.Red)  txtUsrId.Focus();
				if(label1.ForeColor==Color.Red)  txtName.Focus();
				return true;
			}
			
			
			if (txtPassCode.Text != txtConfirmPassCode.Text)
			{
				MessageBox.Show("Error in PassCode","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.txtPassCode.Clear(); 
				this.txtConfirmPassCode.Clear();
				this.txtPassCode.Focus();
				return true;
			} 

			cmpIsNum temp = new cmpIsNum();

			if (temp.isNumric(txtAmtPaid.Text)==false)
			{
				MessageBox.Show(this,"Invalid Amount","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtAmtPaid.Clear();
				txtAmtPaid.Focus();
				return true;
			}  
//			DataView dtvTemp= new DataView(dsMemb1.Tables[0],"","User ID",DataViewRowState.CurrentRows);
//			int rowIndex=dtvTemp.Find(txtUsrId.Text);
//			if (rowIndex!=-1)
//			{
//				MessageBox.Show("User Id already there!!!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
//				this.txtUsrId.Focus();
//				return true;
//			}


			return false;
		}

		private void txtName_TextChanged(object sender, System.EventArgs e)
		{
			label1.ForeColor =Color.Black;
		
		}

		private void txtUsrId_TextChanged(object sender, System.EventArgs e)
		{
			label7.ForeColor =Color.Black;
		}

		private void txtPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label8.ForeColor =Color.Black;
		}

		private void txtConfirmPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label9.ForeColor =Color.Black;
		}

		private void txtAmtPaid_TextChanged(object sender, System.EventArgs e)
		{
			label10.ForeColor =Color.Black;		
		}

		private void txtAdd_TextChanged(object sender, System.EventArgs e)
		{
			label2.ForeColor =Color.Black;
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void frmMem_Load(object sender, System.EventArgs e)
		{
		this.txtName.Text=dsMemb1.Tables[0].Rows[recordNo]["Name"].ToString() ;
        this.txtUsrId.Text = dsMemb1.Tables[0].Rows[recordNo]["User ID"].ToString();
		this.txtAmtPaid.Text=dsMemb1.Tables[0].Rows[recordNo]["Amount"].ToString() ;
		this.txtParent.Text=dsMemb1.Tables[0].Rows[recordNo]["Parentage"].ToString() ;
		this.txtAdd .Text=dsMemb1.Tables[0].Rows[recordNo]["Address"].ToString() ;
		this.txtPassCode.Text=dsMemb1.Tables[0].Rows[recordNo]["PassCode"].ToString() ;
		this.txtFavour.Text=dsMemb1.Tables[0].Rows[recordNo]["Favourite Sites"].ToString();
		this.txtID .Text=dsMemb1.Tables[0].Rows[recordNo]["E-Mail Id"].ToString() ;
		this.txtConfirmPassCode .Text=dsMemb1.Tables[0].Rows[recordNo]["PassCode"].ToString() ;
		
		}

		
	}
	
}
