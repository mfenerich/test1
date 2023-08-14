namespace Generated {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ms-direct.ch/soap/msSoapDataHandling")]
    public partial class ProductStockRequest {
        /// <remarks/>
        public ProductStockRequestMessageHeader messageHeader { get; set; }

        /// <remarks/>
        public ProductStockRequestRequestProductStock requestProductStock { get; set; }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ms-direct.ch/soap/msSoapDataHandling")]
    public partial class ProductStockRequestMessageHeader {
        /// <remarks/>
        public string clientId { get; set; }

        /// <remarks/>
        public string clientName { get; set; }

        /// <remarks/>
        public string token { get; set; }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ms-direct.ch/soap/msSoapDataHandling")]
    public partial class ProductStockRequestRequestProductStock {
        private bool _requestDateFieldSpecified;
        
        private System.DateTime _requestTimeField;
        
        private bool _requestTimeFieldSpecified;
        
        private string _itemNoField;
        
        /// <remarks/>
        public bool onlyStockItems { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime requestDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestDateSpecified {
            get {
                return this._requestDateFieldSpecified;
            }
            set {
                this._requestDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime requestTime {
            get {
                return this._requestTimeField;
            }
            set {
                this._requestTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestTimeSpecified {
            get {
                return this._requestTimeFieldSpecified;
            }
            set {
                this._requestTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string itemNo {
            get {
                return this._itemNoField;
            }
            set {
                this._itemNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ms-direct.ch/soap/msSoapDataHandling")]
    public partial class productStockResponse {
        /// <remarks/>
        public productStockResponseMessageHeader messageHeader { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("productStockItem", IsNullable=false)]
        public productStockItem[] productStockItems { get; set; }
        
        /// <remarks/>
        public productStockResponseError error { get; set; }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true/*, Namespace="http://ms-direct.ch/soap/msSoapDataHandling"*/)]
    public partial class productStockResponseMessageHeader {
        
        private string clientIdField;
        
        private string clientNameField;
        
        private string tokenField;
        
        /// <remarks/>
        public string clientId {
            get {
                return this.clientIdField;
            }
            set {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        public string clientName {
            get {
                return this.clientNameField;
            }
            set {
                this.clientNameField = value;
            }
        }
        
        /// <remarks/>
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true/*, Namespace="http://ms-direct.ch/soap/msSoapDataHandling"*/)]
    public partial class productStockItem {
        
        private string itemNoField;
        
        private decimal calculatetQuantityField;
        
        private decimal qtyOnScrappingStoreField;
        
        private bool qtyOnScrappingStoreFieldSpecified;
        
        private System.DateTime statusDatumField;
        
        private bool blockedField;
        
        private decimal qtyOnPurchOrderField;
        
        private bool qtyOnPurchOrderFieldSpecified;
        
        private string expectedReceiptDateField;
        
        private string vendorItemNoField;
        
        private decimal qtyOnExternalStockField;
        
        private bool qtyOnExternalStockFieldSpecified;
        
        private decimal qtyOnLocalStockField;
        
        private bool qtyOnLocalStockFieldSpecified;
        
        private decimal qtyOnSalesOrderField;
        
        private bool qtyOnSalesOrderFieldSpecified;
        
        private string eanField;
        
        /// <remarks/>
        public string itemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public decimal calculatetQuantity {
            get {
                return this.calculatetQuantityField;
            }
            set {
                this.calculatetQuantityField = value;
            }
        }
        
        /// <remarks/>
        public decimal qtyOnScrappingStore {
            get {
                return this.qtyOnScrappingStoreField;
            }
            set {
                this.qtyOnScrappingStoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyOnScrappingStoreSpecified {
            get {
                return this.qtyOnScrappingStoreFieldSpecified;
            }
            set {
                this.qtyOnScrappingStoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime statusDatum {
            get {
                return this.statusDatumField;
            }
            set {
                this.statusDatumField = value;
            }
        }
        
        /// <remarks/>
        public bool blocked {
            get {
                return this.blockedField;
            }
            set {
                this.blockedField = value;
            }
        }
        
        /// <remarks/>
        public decimal qtyOnPurchOrder {
            get {
                return this.qtyOnPurchOrderField;
            }
            set {
                this.qtyOnPurchOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyOnPurchOrderSpecified {
            get {
                return this.qtyOnPurchOrderFieldSpecified;
            }
            set {
                this.qtyOnPurchOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string expectedReceiptDate {
            get {
                return this.expectedReceiptDateField;
            }
            set {
                this.expectedReceiptDateField = value;
            }
        }
        
        /// <remarks/>
        public string vendorItemNo {
            get {
                return this.vendorItemNoField;
            }
            set {
                this.vendorItemNoField = value;
            }
        }
        
        /// <remarks/>
        public decimal qtyOnExternalStock {
            get {
                return this.qtyOnExternalStockField;
            }
            set {
                this.qtyOnExternalStockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyOnExternalStockSpecified {
            get {
                return this.qtyOnExternalStockFieldSpecified;
            }
            set {
                this.qtyOnExternalStockFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal qtyOnLocalStock {
            get {
                return this.qtyOnLocalStockField;
            }
            set {
                this.qtyOnLocalStockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyOnLocalStockSpecified {
            get {
                return this.qtyOnLocalStockFieldSpecified;
            }
            set {
                this.qtyOnLocalStockFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal qtyOnSalesOrder {
            get {
                return this.qtyOnSalesOrderField;
            }
            set {
                this.qtyOnSalesOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyOnSalesOrderSpecified {
            get {
                return this.qtyOnSalesOrderFieldSpecified;
            }
            set {
                this.qtyOnSalesOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ean {
            get {
                return this.eanField;
            }
            set {
                this.eanField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true/*, Namespace="http://ms-direct.ch/soap/msSoapDataHandling"*/)]
    public partial class productStockResponseError {
        /// <remarks/>
        public string errorCode { get; set; }

        /// <remarks/>
        public string errorMessage { get; set; }
    }
}