﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Client {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsclient : DataSet {
        
        private ServerInfoDataTable tableServerInfo;
        
        public dsclient() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsclient(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["ServerInfo"] != null)) {
                    this.Tables.Add(new ServerInfoDataTable(ds.Tables["ServerInfo"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ServerInfoDataTable ServerInfo {
            get {
                return this.tableServerInfo;
            }
        }
        
        public override DataSet Clone() {
            dsclient cln = ((dsclient)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["ServerInfo"] != null)) {
                this.Tables.Add(new ServerInfoDataTable(ds.Tables["ServerInfo"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableServerInfo = ((ServerInfoDataTable)(this.Tables["ServerInfo"]));
            if ((this.tableServerInfo != null)) {
                this.tableServerInfo.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsclient";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsclient.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableServerInfo = new ServerInfoDataTable();
            this.Tables.Add(this.tableServerInfo);
        }
        
        private bool ShouldSerializeServerInfo() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ServerInfoRowChangeEventHandler(object sender, ServerInfoRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ServerInfoDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnFlag;
            
            private DataColumn columnIpAddress;
            
            private DataColumn columnServerName;
            
            private DataColumn columnShare;
            
            internal ServerInfoDataTable() : 
                    base("ServerInfo") {
                this.InitClass();
            }
            
            internal ServerInfoDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn FlagColumn {
                get {
                    return this.columnFlag;
                }
            }
            
            internal DataColumn IpAddressColumn {
                get {
                    return this.columnIpAddress;
                }
            }
            
            internal DataColumn ServerNameColumn {
                get {
                    return this.columnServerName;
                }
            }
            
            internal DataColumn ShareColumn {
                get {
                    return this.columnShare;
                }
            }
            
            public ServerInfoRow this[int index] {
                get {
                    return ((ServerInfoRow)(this.Rows[index]));
                }
            }
            
            public event ServerInfoRowChangeEventHandler ServerInfoRowChanged;
            
            public event ServerInfoRowChangeEventHandler ServerInfoRowChanging;
            
            public event ServerInfoRowChangeEventHandler ServerInfoRowDeleted;
            
            public event ServerInfoRowChangeEventHandler ServerInfoRowDeleting;
            
            public void AddServerInfoRow(ServerInfoRow row) {
                this.Rows.Add(row);
            }
            
            public ServerInfoRow AddServerInfoRow(string Flag, string IpAddress, string ServerName, string Share) {
                ServerInfoRow rowServerInfoRow = ((ServerInfoRow)(this.NewRow()));
                rowServerInfoRow.ItemArray = new object[] {
                        Flag,
                        IpAddress,
                        ServerName,
                        Share};
                this.Rows.Add(rowServerInfoRow);
                return rowServerInfoRow;
            }
            
            public ServerInfoRow FindByFlag(string Flag) {
                return ((ServerInfoRow)(this.Rows.Find(new object[] {
                            Flag})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ServerInfoDataTable cln = ((ServerInfoDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ServerInfoDataTable();
            }
            
            internal void InitVars() {
                this.columnFlag = this.Columns["Flag"];
                this.columnIpAddress = this.Columns["IpAddress"];
                this.columnServerName = this.Columns["ServerName"];
                this.columnShare = this.Columns["Share"];
            }
            
            private void InitClass() {
                this.columnFlag = new DataColumn("Flag", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFlag);
                this.columnIpAddress = new DataColumn("IpAddress", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIpAddress);
                this.columnServerName = new DataColumn("ServerName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnServerName);
                this.columnShare = new DataColumn("Share", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShare);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnFlag}, true));
                this.columnFlag.AllowDBNull = false;
                this.columnFlag.Unique = true;
            }
            
            public ServerInfoRow NewServerInfoRow() {
                return ((ServerInfoRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ServerInfoRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ServerInfoRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ServerInfoRowChanged != null)) {
                    this.ServerInfoRowChanged(this, new ServerInfoRowChangeEvent(((ServerInfoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ServerInfoRowChanging != null)) {
                    this.ServerInfoRowChanging(this, new ServerInfoRowChangeEvent(((ServerInfoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ServerInfoRowDeleted != null)) {
                    this.ServerInfoRowDeleted(this, new ServerInfoRowChangeEvent(((ServerInfoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ServerInfoRowDeleting != null)) {
                    this.ServerInfoRowDeleting(this, new ServerInfoRowChangeEvent(((ServerInfoRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveServerInfoRow(ServerInfoRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ServerInfoRow : DataRow {
            
            private ServerInfoDataTable tableServerInfo;
            
            internal ServerInfoRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableServerInfo = ((ServerInfoDataTable)(this.Table));
            }
            
            public string Flag {
                get {
                    return ((string)(this[this.tableServerInfo.FlagColumn]));
                }
                set {
                    this[this.tableServerInfo.FlagColumn] = value;
                }
            }
            
            public string IpAddress {
                get {
                    try {
                        return ((string)(this[this.tableServerInfo.IpAddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableServerInfo.IpAddressColumn] = value;
                }
            }
            
            public string ServerName {
                get {
                    try {
                        return ((string)(this[this.tableServerInfo.ServerNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableServerInfo.ServerNameColumn] = value;
                }
            }
            
            public string Share {
                get {
                    try {
                        return ((string)(this[this.tableServerInfo.ShareColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableServerInfo.ShareColumn] = value;
                }
            }
            
            public bool IsIpAddressNull() {
                return this.IsNull(this.tableServerInfo.IpAddressColumn);
            }
            
            public void SetIpAddressNull() {
                this[this.tableServerInfo.IpAddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsServerNameNull() {
                return this.IsNull(this.tableServerInfo.ServerNameColumn);
            }
            
            public void SetServerNameNull() {
                this[this.tableServerInfo.ServerNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsShareNull() {
                return this.IsNull(this.tableServerInfo.ShareColumn);
            }
            
            public void SetShareNull() {
                this[this.tableServerInfo.ShareColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ServerInfoRowChangeEvent : EventArgs {
            
            private ServerInfoRow eventRow;
            
            private DataRowAction eventAction;
            
            public ServerInfoRowChangeEvent(ServerInfoRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ServerInfoRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
