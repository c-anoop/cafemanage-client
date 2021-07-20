using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Threading;  

namespace Client
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 

	public class frmClient : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem mnuOpt;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem submnuUsr;
		private System.Windows.Forms.MainMenu mnuMain;
		private System.IO.FileSystemWatcher flWatcher;
		private System.Windows.Forms.ContextMenu cntmenu;
		private System.Windows.Forms.NotifyIcon nfyIcon;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem cntMnuMainWin;
		const int READ_BUFFER_SIZE = 255;
		const int PORT_NUM = 10000;
		private TcpClient client;
		private byte[] readBuffer=new byte[READ_BUFFER_SIZE];
		public static string  serverDatabasePath;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox txtMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtChat;
		private System.Windows.Forms.Button bttnSend;
		public static string serverAddr;
		public static string serverName;
		public static string serverShare;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Client.dsclient dsclient1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuItem submnuOptionsLogOut;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer4;
		private string temppath = Application.StartupPath + @"\client.mdb";
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbConnection oleDbConnection2;
		private Client.DataSet1 dataSet11;
		private bool boolTemp3=false;
		public frmClient()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + temppath + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";

			dsclient1.Clear ();
			oleDbDataAdapter1.Fill(dsclient1);
			dataSet11.Clear();
			oleDbDataAdapter2.Fill(dataSet11);
 			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			flWatcher.Path =@"C:\WINDOWS";
			flWatcher.IncludeSubdirectories =true;
	
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClient));
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.mnuOpt = new System.Windows.Forms.MenuItem();
			this.submnuOptionsLogOut = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.submnuUsr = new System.Windows.Forms.MenuItem();
			this.flWatcher = new System.IO.FileSystemWatcher();
			this.cntmenu = new System.Windows.Forms.ContextMenu();
			this.cntMnuMainWin = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.nfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bttnSend = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtChat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMain = new System.Windows.Forms.ListBox();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsclient1 = new Client.dsclient();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Client.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.flWatcher)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsclient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuOpt,
																					this.menuItem3});
			// 
			// mnuOpt
			// 
			this.mnuOpt.Index = 0;
			this.mnuOpt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.submnuOptionsLogOut,
																				   this.menuItem1});
			this.mnuOpt.Text = "&Options";
			// 
			// submnuOptionsLogOut
			// 
			this.submnuOptionsLogOut.Index = 0;
			this.submnuOptionsLogOut.Text = "Log Out";
			this.submnuOptionsLogOut.Click += new System.EventHandler(this.submnuOptionsLogOut_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.submnuUsr});
			this.menuItem3.Text = "&Edit";
			// 
			// submnuUsr
			// 
			this.submnuUsr.Index = 0;
			this.submnuUsr.Text = "Member";
			this.submnuUsr.Click += new System.EventHandler(this.submnuUsr_Click);
			// 
			// flWatcher
			// 
			this.flWatcher.EnableRaisingEvents = true;
			this.flWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
			this.flWatcher.SynchronizingObject = this;
			this.flWatcher.Deleted += new System.IO.FileSystemEventHandler(this.flWatcher_Deleted);
			// 
			// cntmenu
			// 
			this.cntmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.cntMnuMainWin,
																					this.menuItem4});
			// 
			// cntMnuMainWin
			// 
			this.cntMnuMainWin.Index = 0;
			this.cntMnuMainWin.Text = "Open\'s Main Window";
			this.cntMnuMainWin.Click += new System.EventHandler(this.cntMnuMainWin_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// nfyIcon
			// 
			this.nfyIcon.ContextMenu = this.cntmenu;
			this.nfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyIcon.Icon")));
			this.nfyIcon.Text = "Cafe Manager - Client";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.bttnSend,
																					this.label2,
																					this.txtChat,
																					this.label1,
																					this.txtMain});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Send Message to Server";
			// 
			// bttnSend
			// 
			this.bttnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSend.Location = new System.Drawing.Point(232, 208);
			this.bttnSend.Name = "bttnSend";
			this.bttnSend.TabIndex = 4;
			this.bttnSend.Text = "&Send";
			this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Type Message here  :";
			// 
			// txtChat
			// 
			this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChat.Location = new System.Drawing.Point(144, 176);
			this.txtChat.Name = "txtChat";
			this.txtChat.Size = new System.Drawing.Size(192, 20);
			this.txtChat.TabIndex = 2;
			this.txtChat.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(112, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = " Chat Window";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMain
			// 
			this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMain.Location = new System.Drawing.Point(8, 40);
			this.txtMain.Name = "txtMain";
			this.txtMain.Size = new System.Drawing.Size(328, 119);
			this.txtMain.TabIndex = 0;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "ServerInfo", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("ServerName", "ServerName"),
																																																					  new System.Data.Common.DataColumnMapping("IpAddress", "IpAddress"),
																																																					  new System.Data.Common.DataColumnMapping("Flag", "Flag"),
																																																					  new System.Data.Common.DataColumnMapping("Share", "Share")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM ServerInfo WHERE (Flag = ?) AND (IpAddress = ? OR ? IS NULL AND IpAdd" +
				"ress IS NULL) AND (ServerName = ? OR ? IS NULL AND ServerName IS NULL) AND (Shar" +
				"e = ? OR ? IS NULL AND Share IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Flag", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Flag", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IpAddress", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IpAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IpAddress1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IpAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ServerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ServerName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ServerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ServerName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Share", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Share", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Share1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Share", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO ServerInfo(Flag, IpAddress, ServerName, Share) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Flag", System.Data.OleDb.OleDbType.VarWChar, 50, "Flag"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("IpAddress", System.Data.OleDb.OleDbType.VarWChar, 50, "IpAddress"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ServerName", System.Data.OleDb.OleDbType.VarWChar, 50, "ServerName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Share", System.Data.OleDb.OleDbType.VarWChar, 50, "Share"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Flag, IpAddress, ServerName, Share FROM ServerInfo";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE ServerInfo SET Flag = ?, IpAddress = ?, ServerName = ?, Share = ? WHERE (F" +
				"lag = ?) AND (IpAddress = ? OR ? IS NULL AND IpAddress IS NULL) AND (ServerName " +
				"= ? OR ? IS NULL AND ServerName IS NULL) AND (Share = ? OR ? IS NULL AND Share I" +
				"S NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Flag", System.Data.OleDb.OleDbType.VarWChar, 50, "Flag"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("IpAddress", System.Data.OleDb.OleDbType.VarWChar, 50, "IpAddress"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ServerName", System.Data.OleDb.OleDbType.VarWChar, 50, "ServerName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Share", System.Data.OleDb.OleDbType.VarWChar, 50, "Share"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Flag", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Flag", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IpAddress", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IpAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IpAddress1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IpAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ServerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ServerName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ServerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ServerName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Share", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Share", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Share1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Share", System.Data.DataRowVersion.Original, null));
			// 
			// dsclient1
			// 
			this.dsclient1.DataSetName = "dsclient";
			this.dsclient1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsclient1.Namespace = "http://www.tempuri.org/dsclient.xsd";
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 60000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// timer4
			// 
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM member WHERE (ID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Balanced Time] = ? OR ? IS NULL AND [Balanced Time] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND ([Favourite Sites] = ? OR ? IS NULL AND [Favourite Sites] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Parentage = ? OR ? IS NULL AND Parentage IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND ([Total Time Alloted] = ? OR ? IS NULL AND [Total Time Alloted] IS NULL) AND ([User ID] = ? OR ? IS NULL AND [User ID] IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection2;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection2
			// 
			this.oleDbConnection2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=\\Node-1\abc\CafeManager\bin\Debug\member.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO member(Address, Amount, [Balanced Time], [Date], [E-Mail ID], [Favour" +
				"ite Sites], ID, Name, Parentage, PassCode, [Total Time Alloted], [User ID]) VALU" +
				"ES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection2;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, "Favourite Sites"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, "Parentage"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Address, Amount, [Balanced Time], [Date], [E-Mail ID], [Favourite Sites], " +
				"ID, Name, Parentage, PassCode, [Total Time Alloted], [User ID] FROM member";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection2;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE member SET Address = ?, Amount = ?, [Balanced Time] = ?, [Date] = ?, [E-Mail ID] = ?, [Favourite Sites] = ?, ID = ?, Name = ?, Parentage = ?, PassCode = ?, [Total Time Alloted] = ?, [User ID] = ? WHERE (ID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Balanced Time] = ? OR ? IS NULL AND [Balanced Time] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND ([Favourite Sites] = ? OR ? IS NULL AND [Favourite Sites] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Parentage = ? OR ? IS NULL AND Parentage IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND ([Total Time Alloted] = ? OR ? IS NULL AND [Total Time Alloted] IS NULL) AND ([User ID] = ? OR ? IS NULL AND [User ID] IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection2;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, "Favourite Sites"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, "Parentage"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Balanced_Time1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Balanced Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Favourite_Sites1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Favourite Sites", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Parentage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Parentage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time_Alloted1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Total Time Alloted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// frmClient
			// 
			this.AcceptButton = this.bttnSend;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(360, 257);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mnuMain;
			this.Name = "frmClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Node - ";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmClient_Closing);
			this.Load += new System.EventHandler(this.frmClient_Load);
			this.DragLeave += new System.EventHandler(this.frmClient_DragLeave);
			((System.ComponentModel.ISupportInitialize)(this.flWatcher)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsclient1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmClient());
		}

		private void sbmnuCngUsrPass_Click(object sender, System.EventArgs e)
		{
			
		}

		private void submnuUsr_Click(object sender, System.EventArgs e)
		{
			frmSecurity frmTemp1 = new frmSecurity();
			frmTemp1.ShowDialog();
			if ((string)frmTemp1.Tag=="Access Granted")
			{
				frmMem frmTemp2= new frmMem(frmSecurity.recNo);
				frmTemp2.ShowDialog();
			}
		}

		private void frmClient_Load(object sender, System.EventArgs e)
		{
        	this.Hide();
			this.nfyIcon.Visible=true; 
			this.Text = "  "+Dns.GetHostName();

			if (dsclient1.Tables[0].Rows[0]["Flag"].ToString()=="False")
				
			{
				frmServerInfo frmTemp3 = new frmServerInfo();
				frmTemp3.ShowDialog();
			
				if (frmServerInfo.boolTemp1==true)
				{
					dsclient1.Tables[0].Rows[0]["Flag"]="True";
					dsclient1.Tables[0].Rows[0]["ServerName"]=frmServerInfo.servername;
					dsclient1.Tables[0].Rows[0]["IpAddress"]=frmServerInfo.ipaddr;
					dsclient1.Tables[0].Rows[0]["Share"]=frmServerInfo.share;
					oleDbDataAdapter1.Update(dsclient1); 
				}
			}
			 serverName=dsclient1.Tables[0].Rows[0]["ServerName"].ToString();
			 serverAddr=dsclient1.Tables[0].Rows[0]["IpAddress"].ToString();
			 serverShare=dsclient1.Tables[0].Rows[0]["Share"].ToString();
			try
			{
				client = new TcpClient(serverAddr, PORT_NUM);
				client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, new AsyncCallback(DoRead), null);
				this.Show();
				AttemptLogin();
				SendData("PATH");
			}
			catch 
			{
				MessageBox.Show("Server is not active.  Please start server and try again.", this.Text);
				this.Dispose();
				Application.Exit();
			}
            timer2.Start();
			timer1.Start();
		}

		private void frmClient_DragLeave(object sender, System.EventArgs e)
		{
			nfyIcon.Dispose();
		}

		private void cntMnuMainWin_Click(object sender, System.EventArgs e)
		{
			this.Show();
		}

		private void frmClient_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide ();
			if (!boolTemp3)
			e.Cancel=true; 
			
        }

		private void flWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
		{
			SendData("DELETED|" + "A file named " +  e.FullPath + " was deleted from " + Dns.GetHostName());
		}
	
		// Connection part
		private void DoRead(IAsyncResult ar)
		{
			int BytesRead;
			string strMessage;

			try
			{
				BytesRead=client.GetStream().EndRead(ar);
				if (BytesRead < 1)
				{
					MarkAsDisconnected();
					return;
				}
				strMessage = Encoding.ASCII.GetString(readBuffer, 0, BytesRead - 2);
				ProcessCommands(strMessage);
				client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, new AsyncCallback(DoRead), null);
			}
			catch
			{
				MarkAsDisconnected();
			} 
		}
		private void MarkAsDisconnected()
		{
			txtChat.ReadOnly = true;
			bttnSend.Enabled = false;
		}

		private void ProcessCommands(string strMessage)
		{
			string[] dataArray=new string[100];
			dataArray = strMessage.Split((char)124);

			switch (dataArray[0])
			{
				case "JOIN":
					DisplayText("You have joined the chat");
					break;

//				case "CHAT":
//					DisplayText(dataArray[1]);
//					break;

				case "REFUSE":
					AttemptLogin();
					break;
					
				case "BROAD":
					DisplayText("ServerMessage: " + dataArray[1]);
					break;
				case "NETON":
					MessageBox.Show ("Net connected");
					break;
				case "NETOFF": MessageBox.Show ("Net disconnected");
					break;

				case "PATH": serverDatabasePath=dataArray[1];
					break; 

				case "SHUTDOWN":
				{   boolTemp3=true;
					SendData("DISCONNECT|" + Dns.GetHostName());
					System.Diagnostics.Process.Start("shtdwn.exe");
				}
					break;
				case "LOGOFFALL":
				{   boolTemp3=true;
					SendData("DISCONNECT|"+Dns.GetHostName ());
					System.Diagnostics.Process.Start("lgoff.exe");
				}
					break;
				case "REBOOTALL":
				{   
					boolTemp3=true;
					SendData("DISCONNECT|"+Dns.GetHostName ());
					System.Diagnostics.Process.Start("rebt.exe");
				}
					break;
			}
		}

		private  void SendData(string data)
		{
			System.IO.StreamWriter writer = new System.IO.StreamWriter(client.GetStream());
			writer.Write(data + (char)13);
			writer.Flush();
		}

		private void AttemptLogin()
		{
			SendData("CONNECT|" + Dns.GetHostName());
		}

		private void bttnSend_Click(object sender, System.EventArgs e)
		{
			if (txtChat.Text != "" )
			{
				DisplayText("You say: " + txtChat.Text);
				SendData("CHAT|" + txtChat.Text);
				txtChat.Text = "";
			}
		}

		private void DisplayText(string text)
		{
			this.txtMain.Items.Add (text);
		}
			
		private void Security()
        {
		
		}
		
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
		    frmLogin frmTemp4 = new frmLogin();	
			frmTemp4.ShowDialog();
	
			if((string)frmTemp4.Tag =="Change Color")
				SendData("COLOR|"+Dns.GetHostName());
		}

		private void submnuOptionsLogOut_Click(object sender, System.EventArgs e)
		{
			timer3.Stop();
			int a=frmLogin.recNo;
			int t;
			if(frmLogin.userMember =="user")
			SendData("TIME|" + timeCount.ToString());
			if(frmLogin.userMember == "mem")
			{
				t=Convert.ToInt32 (frmLogin.baltime) - timeCount;
				dataSet11.Tables[0].Rows[a]["Balanced Time"]=t;
				oleDbDataAdapter2.Update(dataSet11);
			}
			SendData("LOGOUT|" + Dns.GetHostName());
			timer4.Start();
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if (frmLogin.boolValid1)
            {  timer2.Stop(); 
			   timer3.Start();
			}
		}
        
		int timeCount=0;
		
		private void timer3_Tick(object sender, System.EventArgs e)
		{   
		
			if (Convert.ToInt32 (frmLogin.baltime)>timeCount)
			    timeCount++;
			else
			{
				timer3.Stop();
//				MessageBox.Show("Your account time is over!!!");
				Application.Exit();
				System.Diagnostics.Process.Start("client.exe");
			}
		}

		private void timer4_Tick(object sender, System.EventArgs e)
		{
			timer4.Stop();
			Application.Exit();
			System.Diagnostics.Process.Start("client.exe");
		
		}

		
	}
}                                                                                                
