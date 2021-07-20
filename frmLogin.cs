using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace Client
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	/// 
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbUser;
		private System.Windows.Forms.RadioButton rbMember;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPassCode;
		private System.Windows.Forms.Button btnOk;
		private string tempPath=frmClient.serverDatabasePath + @"\member.mdb" ;
		public static int recNo;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUserId;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lblUserMsg;
		private System.Windows.Forms.Label label5;
		private TcpClient client;
		public int intTemp1;
		public int intTemp2;
		public static string baltime;
		public static bool boolValid1=false;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Client.dsLogin dsLogin1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		public static string userMember;

		        
		public frmLogin()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();
			//
			//oleDbConnection
			//
			string [] array1 = new string[2];
			array1= tempPath.Split(new char[]{':'},2);
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=\\" + frmClient.serverName +  @"\" + frmClient.serverShare + array1[1].ToString() + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			try
			{
				dsLogin1.Clear();
				oleDbDataAdapter1.Fill(dsLogin1);
				oleDbDataAdapter2.Fill(dsLogin1);


			}
			catch (Exception)
			{
				MessageBox.Show (" Network Connection is not established try again");
				this.Dispose();
			}

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.rbMember = new System.Windows.Forms.RadioButton();
			this.rbUser = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblUserMsg = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.txtPassCode = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsLogin1 = new Client.dsLogin();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsLogin1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.groupBox2});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(240, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 280);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Required Information :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.btnOk,
																					this.rbMember,
																					this.rbUser,
																					this.groupBox4,
																					this.groupBox3});
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 256);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Location = new System.Drawing.Point(200, 216);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(64, 24);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "&OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// rbMember
			// 
			this.rbMember.Location = new System.Drawing.Point(24, 48);
			this.rbMember.Name = "rbMember";
			this.rbMember.Size = new System.Drawing.Size(104, 16);
			this.rbMember.TabIndex = 1;
			this.rbMember.Text = "Member";
			this.rbMember.Click += new System.EventHandler(this.rbMember_Click);
			this.rbMember.CheckedChanged += new System.EventHandler(this.rbMember_CheckedChanged);
			// 
			// rbUser
			// 
			this.rbUser.Checked = true;
			this.rbUser.Location = new System.Drawing.Point(24, 16);
			this.rbUser.Name = "rbUser";
			this.rbUser.Size = new System.Drawing.Size(88, 24);
			this.rbUser.TabIndex = 0;
			this.rbUser.TabStop = true;
			this.rbUser.Text = "User";
			this.rbUser.Click += new System.EventHandler(this.rbUser_Click);
			this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label5,
																					this.lblUserMsg,
																					this.txtUserId,
																					this.label4});
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(8, 80);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 128);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Checking User Permissions :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(96, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "User-";
			// 
			// lblUserMsg
			// 
			this.lblUserMsg.Location = new System.Drawing.Point(16, 88);
			this.lblUserMsg.Name = "lblUserMsg";
			this.lblUserMsg.Size = new System.Drawing.Size(216, 24);
			this.lblUserMsg.TabIndex = 4;
			this.lblUserMsg.Text = "Invalid User Id !!!";
			this.lblUserMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblUserMsg.Visible = false;
			// 
			// txtUserId
			// 
			this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUserId.Location = new System.Drawing.Point(128, 40);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(24, 20);
			this.txtUserId.TabIndex = 0;
			this.txtUserId.Text = "";
			this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "User Id    :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.lblMessage,
																					this.txtPassCode,
																					this.txtId,
																					this.label2,
																					this.label1});
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(8, 80);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(264, 128);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Checking Member Permissions :";
			this.groupBox3.Visible = false;
			// 
			// lblMessage
			// 
			this.lblMessage.Location = new System.Drawing.Point(24, 96);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(216, 24);
			this.lblMessage.TabIndex = 4;
			this.lblMessage.Text = "Invalid User-Id or PassCode!!!";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMessage.Visible = false;
			// 
			// txtPassCode
			// 
			this.txtPassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassCode.Location = new System.Drawing.Point(128, 56);
			this.txtPassCode.Name = "txtPassCode";
			this.txtPassCode.PasswordChar = '*';
			this.txtPassCode.Size = new System.Drawing.Size(88, 20);
			this.txtPassCode.TabIndex = 1;
			this.txtPassCode.Text = "";
			this.txtPassCode.TextChanged += new System.EventHandler(this.txtPassCode_TextChanged);
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Location = new System.Drawing.Point(128, 24);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 20);
			this.txtId.TabIndex = 0;
			this.txtId.Text = "";
			this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "PassCode    :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "User-Id        :";
			// 
			// timer1
			// 
			this.timer1.Interval = 2500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=\\Node-1\abc\CafeManager\bin\Debug\member.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
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
			// dsLogin1
			// 
			this.dsLogin1.DataSetName = "dsLogin";
			this.dsLogin1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsLogin1.Namespace = "http://www.tempuri.org/dsLogin.xsd";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("Name", "Name"),
																																																				new System.Data.Common.DataColumnMapping("E-Mail ID", "E-Mail ID"),
																																																				new System.Data.Common.DataColumnMapping("Total Time", "Total Time"),
																																																				new System.Data.Common.DataColumnMapping("Amount", "Amount"),
																																																				new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																				new System.Data.Common.DataColumnMapping("User ID", "User ID"),
																																																				new System.Data.Common.DataColumnMapping("Login", "Login"),
																																																				new System.Data.Common.DataColumnMapping("Logout", "Logout")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM [user] WHERE ([User ID] = ?) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND (Login = ? OR ? IS NULL AND Login IS NULL) AND (Logout = ? OR ? IS NULL AND Logout IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND ([Total Time] = ? OR ? IS NULL AND [Total Time] IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO [user] (Amount, [Date], [E-Mail ID], Login, Logout, Name, [Total Time" +
				"], [User ID]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.DBDate, 0, "Login"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Logout", System.Data.OleDb.OleDbType.DBDate, 0, "Logout"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, "Total Time"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Amount, [Date], [E-Mail ID], Login, Logout, Name, [Total Time], [User ID] " +
				"FROM [user]";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE [user] SET Amount = ?, [Date] = ?, [E-Mail ID] = ?, Login = ?, Logout = ?, Name = ?, [Total Time] = ?, [User ID] = ? WHERE ([User ID] = ?) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND (Login = ? OR ? IS NULL AND Login IS NULL) AND (Logout = ? OR ? IS NULL AND Logout IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND ([Total Time] = ? OR ? IS NULL AND [Total Time] IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.DBDate, 0, "Login"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Logout", System.Data.OleDb.OleDbType.DBDate, 0, "Logout"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, "Total Time"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(812, 448);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.ShowInTaskbar = false;
			this.Text = "frmLogin";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmLogin_Closing);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsLogin1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		private void frmLogin_Load(object sender, System.EventArgs e)
		{
		
			txtUserId.Focus();
			
		}

		private void frmLogin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{  
		}

		public DataView dv;
		
        private void btnOk_Click(object sender, System.EventArgs e)
		{
			if(this.rbUser.Checked)
			{
				dsLogin1.Clear();
				oleDbDataAdapter1.Fill(dsLogin1);
				oleDbDataAdapter2.Fill(dsLogin1);
				DataView dtvTemp1= new DataView(dsLogin1.Tables["user"],"","User ID",DataViewRowState.CurrentRows);
				intTemp1=dtvTemp1.Find("User-" + txtUserId.Text);
				
				if (intTemp1==-1)
				{
				    
					txtUserId.Clear();
					lblUserMsg.Visible =true;
					txtUserId.Focus();
					return;
				}
				else
				{
					userMember="user";
					lblUserMsg.Visible =true;
					this.Tag="Change Color";
					this.lblUserMsg.Text = " Access Granted";
					boolValid1=true;
					timer1.Start();
				}
			}
			if(this.rbMember.Checked)
			{
				dsLogin1.Clear();
				oleDbDataAdapter1.Fill(dsLogin1);
				oleDbDataAdapter2.Fill(dsLogin1);
				DataView dtvTemp1= new DataView(dsLogin1.Tables["member"],"","User ID",DataViewRowState.CurrentRows);
				intTemp2=dtvTemp1.Find(txtId.Text);
				  
				if (intTemp2==-1 || dsLogin1.Tables["member"].Rows[intTemp2]["PassCode"].ToString()!=txtPassCode.Text )
				{
					txtId.Clear();
					txtPassCode.Clear ();
					lblMessage.Visible =true;
					txtId.Focus ();
					return;
				}
				else
				{
					userMember="mem";
					recNo=intTemp2;
     				this.lblMessage.Visible=true;
					this.Tag="Change Color";
				    this.lblMessage.Text = " Access Granted";
					baltime = dsLogin1.Tables[0].Rows[intTemp2]["Balanced Time"].ToString();
					boolValid1=true;
                   	timer1.Start();
				}
			}
		}

		private void rbMember_CheckedChanged(object sender, System.EventArgs e)
		{
            txtId.Clear();
			this.groupBox3.Visible = true;
			this.groupBox4.Visible =false;
		}

		private void rbUser_CheckedChanged(object sender, System.EventArgs e)
		{
          
		    this.groupBox3.Visible=false;
		    this.groupBox4.Visible =true;
		
		}

		private void txtId_TextChanged(object sender, System.EventArgs e)
		{
			lblMessage.Visible =false;
		}

		private void txtPassCode_TextChanged(object sender, System.EventArgs e)
		{
			lblMessage.Visible =false;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			this.Dispose ();
		}

		private  void SendData(string data)
		{
			System.IO.StreamWriter writer = new System.IO.StreamWriter(client.GetStream());
			writer.Write(data + (char)13);
			writer.Flush();
		}

		private void txtUserId_TextChanged(object sender, System.EventArgs e)
		{
			lblUserMsg.Visible =false;
		}

		private void rbUser_Click(object sender, System.EventArgs e)
		{
			txtUserId.Focus();
			this.lblMessage.Visible =false;
		}

		private void rbMember_Click(object sender, System.EventArgs e)
		{
			txtId.Focus();
			this.lblUserMsg.Visible =false;
		}
			
	}
}
