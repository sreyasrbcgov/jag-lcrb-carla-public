// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.opportunityproduct
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunityproduct
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityproduct(string description = default(string), string _opportunityidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? priceperunit = default(decimal?), decimal? tax = default(decimal?), string _modifiedonbehalfbyValue = default(string), string productassociationid = default(string), int? skippricecalculation = default(int?), decimal? extendedamount = default(decimal?), string _createdbyValue = default(string), string _owningteamValue = default(string), decimal? volumediscountamount = default(decimal?), decimal? exchangerate = default(decimal?), bool? isproductoverridden = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? pricingerrorcode = default(int?), int? sequencenumber = default(int?), string entityimageid = default(string), int? producttypecode = default(int?), string _parentbundleidrefValue = default(string), int? utcconversiontimezonecode = default(int?), decimal? baseamountBase = default(decimal?), int? propertyconfigurationstatus = default(int?), decimal? manualdiscountamount = default(decimal?), string owninguser = default(string), string _owneridValue = default(string), string parentbundleid = default(string), string _createdonbehalfbyValue = default(string), string _productidValue = default(string), decimal? taxBase = default(decimal?), string productdescription = default(string), int? timezoneruleversionnumber = default(int?), byte[] entityimage = default(byte[]), string opportunityproductname = default(string), decimal? manualdiscountamountBase = default(decimal?), string entityimageUrl = default(string), string productname = default(string), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), string _modifiedbyValue = default(string), bool? ispriceoverridden = default(bool?), long? entityimageTimestamp = default(long?), int? lineitemnumber = default(int?), string opportunityproductid = default(string), decimal? extendedamountBase = default(decimal?), decimal? volumediscountamountBase = default(decimal?), decimal? baseamount = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? importsequencenumber = default(int?), decimal? quantity = default(decimal?), int? opportunitystatecode = default(int?), string _uomidValue = default(string), decimal? priceperunitBase = default(decimal?), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMteam> opportunityproductTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> opportunityproductMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMprocesssession> opportunityProductProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMasyncoperation> opportunityProductAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> opportunityproductPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> opportunityProductDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMsyncerror> opportunityProductSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunityProductBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMopportunityproduct parentbundleidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), IList<MicrosoftDynamicsCRMopportunityproduct> opportunityproductParentOpportunityproduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>), MicrosoftDynamicsCRMopportunityproduct parentbundleidrefOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), IList<MicrosoftDynamicsCRMopportunityproduct> opportunityproductParentrefOpportunityproduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>))
        {
            Description = description;
            this._opportunityidValue = _opportunityidValue;
            Createdon = createdon;
            Priceperunit = priceperunit;
            Tax = tax;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Productassociationid = productassociationid;
            Skippricecalculation = skippricecalculation;
            Extendedamount = extendedamount;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Volumediscountamount = volumediscountamount;
            Exchangerate = exchangerate;
            Isproductoverridden = isproductoverridden;
            Modifiedon = modifiedon;
            Pricingerrorcode = pricingerrorcode;
            Sequencenumber = sequencenumber;
            Entityimageid = entityimageid;
            Producttypecode = producttypecode;
            this._parentbundleidrefValue = _parentbundleidrefValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BaseamountBase = baseamountBase;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            Manualdiscountamount = manualdiscountamount;
            Owninguser = owninguser;
            this._owneridValue = _owneridValue;
            Parentbundleid = parentbundleid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._productidValue = _productidValue;
            TaxBase = taxBase;
            Productdescription = productdescription;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Entityimage = entityimage;
            Opportunityproductname = opportunityproductname;
            ManualdiscountamountBase = manualdiscountamountBase;
            EntityimageUrl = entityimageUrl;
            Productname = productname;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Ispriceoverridden = ispriceoverridden;
            EntityimageTimestamp = entityimageTimestamp;
            Lineitemnumber = lineitemnumber;
            Opportunityproductid = opportunityproductid;
            ExtendedamountBase = extendedamountBase;
            VolumediscountamountBase = volumediscountamountBase;
            Baseamount = baseamount;
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            Quantity = quantity;
            Opportunitystatecode = opportunitystatecode;
            this._uomidValue = _uomidValue;
            PriceperunitBase = priceperunitBase;
            Owningteam = owningteam;
            OpportunityproductTeams = opportunityproductTeams;
            OpportunityproductMailboxTrackingFolders = opportunityproductMailboxTrackingFolders;
            Productid = productid;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            Opportunityid = opportunityid;
            OpportunityProductProcessSessions = opportunityProductProcessSessions;
            OpportunityProductAsyncOperations = opportunityProductAsyncOperations;
            Modifiedby = modifiedby;
            OpportunityproductPrincipalobjectattributeaccess = opportunityproductPrincipalobjectattributeaccess;
            OpportunityProductDynamicpropertyinstance = opportunityProductDynamicpropertyinstance;
            OpportunityProductSyncErrors = opportunityProductSyncErrors;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Modifiedonbehalfby = modifiedonbehalfby;
            Uomid = uomid;
            Createdonbehalfby = createdonbehalfby;
            OpportunityProductBulkDeleteFailures = opportunityProductBulkDeleteFailures;
            ParentbundleidOpportunityproduct = parentbundleidOpportunityproduct;
            OpportunityproductParentOpportunityproduct = opportunityproductParentOpportunityproduct;
            ParentbundleidrefOpportunityproduct = parentbundleidrefOpportunityproduct;
            OpportunityproductParentrefOpportunityproduct = opportunityproductParentrefOpportunityproduct;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public decimal? Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skippricecalculation")]
        public int? Skippricecalculation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public decimal? Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public decimal? Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentbundleidref_value")]
        public string _parentbundleidrefValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public decimal? BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public decimal? Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public decimal? TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproductname")]
        public string Opportunityproductname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public decimal? ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productname")]
        public string Productname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproductid")]
        public string Opportunityproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public decimal? ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public decimal? VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public decimal? Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitystatecode")]
        public int? Opportunitystatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public decimal? PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_Teams")]
        public IList<MicrosoftDynamicsCRMteam> OpportunityproductTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OpportunityproductMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> OpportunityProductProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunityProductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> OpportunityproductPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> OpportunityProductDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunityProductSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunityProductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct ParentbundleidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_parent_opportunityproduct")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> OpportunityproductParentOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleidref_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct ParentbundleidrefOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_parentref_opportunityproduct")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> OpportunityproductParentrefOpportunityproduct { get; set; }

    }
}
