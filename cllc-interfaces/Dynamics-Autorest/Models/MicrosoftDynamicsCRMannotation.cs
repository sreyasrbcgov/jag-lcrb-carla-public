// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// annotation
    /// </summary>
    public partial class MicrosoftDynamicsCRMannotation
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMannotation
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMannotation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMannotation
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMannotation(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? filesize = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string objecttypecode = default(string), string mimetype = default(string), string _modifiedbyValue = default(string), string documentbody = default(string), object documentbodyBinary = default(object), string _owningteamValue = default(string), long? versionnumber = default(long?), string filename = default(string), string notetext = default(string), string _owninguserValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string stepid = default(string), string annotationid = default(string), string langid = default(string), bool? isdocument = default(bool?), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), string _createdonbehalfbyValue = default(string), string _objectidValue = default(string), string subject = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMknowledgearticle objectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMentitlement objectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementchannel objectidEntitlementchannel = default(MicrosoftDynamicsCRMentitlementchannel), MicrosoftDynamicsCRMentitlementtemplate objectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresource objectidBookableresource = default(MicrosoftDynamicsCRMbookableresource), MicrosoftDynamicsCRMbookableresourcebooking objectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader objectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbookableresourcecategoryassn objectidBookableresourcecategoryassn = default(MicrosoftDynamicsCRMbookableresourcecategoryassn), MicrosoftDynamicsCRMbookableresourcecharacteristic objectidBookableresourcecharacteristic = default(MicrosoftDynamicsCRMbookableresourcecharacteristic), MicrosoftDynamicsCRMbookableresourcegroup objectidBookableresourcegroup = default(MicrosoftDynamicsCRMbookableresourcegroup), MicrosoftDynamicsCRMknowledgebaserecord objectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMaccount objectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlist objectidList = default(MicrosoftDynamicsCRMlist), MicrosoftDynamicsCRMcampaignresponse objectidCampaignresponse = default(MicrosoftDynamicsCRMcampaignresponse), MicrosoftDynamicsCRMkbarticle objectidKbarticle = default(MicrosoftDynamicsCRMkbarticle), MicrosoftDynamicsCRMcampaignactivity objectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMbulkdeletefailure> annotationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla objectidSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMcalendar objectidCalendar = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMfax objectidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMincidentresolution objectidIncidentresolution = default(MicrosoftDynamicsCRMincidentresolution), MicrosoftDynamicsCRMcontact objectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMletter objectidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMservice objectidService = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMsalesorder objectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMquoteclose objectidQuoteclose = default(MicrosoftDynamicsCRMquoteclose), MicrosoftDynamicsCRMcompetitor objectidCompetitor = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMcontract objectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMgoal objectidGoal = default(MicrosoftDynamicsCRMgoal), MicrosoftDynamicsCRMtask objectidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMorderclose objectidOrderclose = default(MicrosoftDynamicsCRMorderclose), MicrosoftDynamicsCRMworkflow objectidWorkflow = default(MicrosoftDynamicsCRMworkflow), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMincident objectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMequipment objectidEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMcontractdetail objectidContractdetail = default(MicrosoftDynamicsCRMcontractdetail), MicrosoftDynamicsCRMcampaign objectidCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> annotationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMlead objectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMmailbox objectidMailbox = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMsocialactivity objectidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMresourcespec objectidResourcespec = default(MicrosoftDynamicsCRMresourcespec), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMduplicaterule objectidDuplicaterule = default(MicrosoftDynamicsCRMduplicaterule), IList<MicrosoftDynamicsCRMsyncerror> annotationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMserviceappointment objectidServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMquote objectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMinvoice objectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMphonecall objectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMemailserverprofile objectidEmailserverprofile = default(MicrosoftDynamicsCRMemailserverprofile), MicrosoftDynamicsCRMopportunityclose objectidOpportunityclose = default(MicrosoftDynamicsCRMopportunityclose), MicrosoftDynamicsCRMproduct objectidProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMopportunity objectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMrecurringappointmentmaster objectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMabsScheduledprocessexecution objectidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMabsScheduledprocessexecution), MicrosoftDynamicsCRMadoxioAgencycommunication objectidAdoxioAgencycommunication = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication objectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint objectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation objectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences objectidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioLocalgovindigenousnation objectidAdoxioLocalgovindigenousnation = default(MicrosoftDynamicsCRMadoxioLocalgovindigenousnation), MicrosoftDynamicsCRMadoxioWorker objectidAdoxioWorker = default(MicrosoftDynamicsCRMadoxioWorker))
        {
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Filesize = filesize;
            Overriddencreatedon = overriddencreatedon;
            Objecttypecode = objecttypecode;
            Mimetype = mimetype;
            this._modifiedbyValue = _modifiedbyValue;
            Documentbody = documentbody;
            DocumentbodyBinary = documentbodyBinary;
            this._owningteamValue = _owningteamValue;
            Versionnumber = versionnumber;
            Filename = filename;
            Notetext = notetext;
            this._owninguserValue = _owninguserValue;
            Createdon = createdon;
            Stepid = stepid;
            Annotationid = annotationid;
            Langid = langid;
            Isdocument = isdocument;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._objectidValue = _objectidValue;
            Subject = subject;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            ObjectidKnowledgearticle = objectidKnowledgearticle;
            ObjectidEntitlement = objectidEntitlement;
            ObjectidEntitlementchannel = objectidEntitlementchannel;
            ObjectidEntitlementtemplate = objectidEntitlementtemplate;
            ObjectidBookableresource = objectidBookableresource;
            ObjectidBookableresourcebooking = objectidBookableresourcebooking;
            ObjectidBookableresourcebookingheader = objectidBookableresourcebookingheader;
            ObjectidBookableresourcecategoryassn = objectidBookableresourcecategoryassn;
            ObjectidBookableresourcecharacteristic = objectidBookableresourcecharacteristic;
            ObjectidBookableresourcegroup = objectidBookableresourcegroup;
            ObjectidKnowledgebaserecord = objectidKnowledgebaserecord;
            ObjectidAccount = objectidAccount;
            Modifiedonbehalfby = modifiedonbehalfby;
            ObjectidList = objectidList;
            ObjectidCampaignresponse = objectidCampaignresponse;
            ObjectidKbarticle = objectidKbarticle;
            ObjectidCampaignactivity = objectidCampaignactivity;
            ObjectidAppointment = objectidAppointment;
            Owningbusinessunit = owningbusinessunit;
            AnnotationBulkDeleteFailures = annotationBulkDeleteFailures;
            ObjectidSla = objectidSla;
            ObjectidCalendar = objectidCalendar;
            Createdby = createdby;
            ObjectidFax = objectidFax;
            ObjectidIncidentresolution = objectidIncidentresolution;
            ObjectidContact = objectidContact;
            Owninguser = owninguser;
            ObjectidLetter = objectidLetter;
            ObjectidService = objectidService;
            ObjectidSalesorder = objectidSalesorder;
            ObjectidQuoteclose = objectidQuoteclose;
            ObjectidCompetitor = objectidCompetitor;
            Ownerid = ownerid;
            ObjectidContract = objectidContract;
            ObjectidGoal = objectidGoal;
            ObjectidTask = objectidTask;
            ObjectidEmail = objectidEmail;
            ObjectidOrderclose = objectidOrderclose;
            ObjectidWorkflow = objectidWorkflow;
            Createdonbehalfby = createdonbehalfby;
            ObjectidIncident = objectidIncident;
            ObjectidEquipment = objectidEquipment;
            ObjectidContractdetail = objectidContractdetail;
            ObjectidCampaign = objectidCampaign;
            Modifiedby = modifiedby;
            AnnotationAsyncOperations = annotationAsyncOperations;
            ObjectidLead = objectidLead;
            ObjectidMailbox = objectidMailbox;
            ObjectidSocialactivity = objectidSocialactivity;
            ObjectidResourcespec = objectidResourcespec;
            Owningteam = owningteam;
            ObjectidDuplicaterule = objectidDuplicaterule;
            AnnotationSyncErrors = annotationSyncErrors;
            ObjectidServiceappointment = objectidServiceappointment;
            ObjectidQuote = objectidQuote;
            ObjectidInvoice = objectidInvoice;
            ObjectidPhonecall = objectidPhonecall;
            ObjectidEmailserverprofile = objectidEmailserverprofile;
            ObjectidOpportunityclose = objectidOpportunityclose;
            ObjectidProduct = objectidProduct;
            ObjectidOpportunity = objectidOpportunity;
            ObjectidRecurringappointmentmaster = objectidRecurringappointmentmaster;
            ObjectidAbsScheduledprocessexecution = objectidAbsScheduledprocessexecution;
            ObjectidAdoxioAgencycommunication = objectidAdoxioAgencycommunication;
            ObjectidAdoxioApplication = objectidAdoxioApplication;
            ObjectidAdoxioComplaint = objectidAdoxioComplaint;
            ObjectidAdoxioInvestigation = objectidAdoxioInvestigation;
            ObjectidAdoxioLicences = objectidAdoxioLicences;
            ObjectidAdoxioLocalgovindigenousnation = objectidAdoxioLocalgovindigenousnation;
            ObjectidAdoxioWorker = objectidAdoxioWorker;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody")]
        public string Documentbody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody_binary")]
        public object DocumentbodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notetext")]
        public string Notetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stepid")]
        public string Stepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "annotationid")]
        public string Annotationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "langid")]
        public string Langid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdocument")]
        public bool? Isdocument { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle ObjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_entitlement")]
        public MicrosoftDynamicsCRMentitlement ObjectidEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_entitlementchannel")]
        public MicrosoftDynamicsCRMentitlementchannel ObjectidEntitlementchannel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_entitlementtemplate")]
        public MicrosoftDynamicsCRMentitlementtemplate ObjectidEntitlementtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresource")]
        public MicrosoftDynamicsCRMbookableresource ObjectidBookableresource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresourcebooking")]
        public MicrosoftDynamicsCRMbookableresourcebooking ObjectidBookableresourcebooking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresourcebookingheader")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader ObjectidBookableresourcebookingheader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresourcecategoryassn")]
        public MicrosoftDynamicsCRMbookableresourcecategoryassn ObjectidBookableresourcecategoryassn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresourcecharacteristic")]
        public MicrosoftDynamicsCRMbookableresourcecharacteristic ObjectidBookableresourcecharacteristic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bookableresourcegroup")]
        public MicrosoftDynamicsCRMbookableresourcegroup ObjectidBookableresourcegroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_knowledgebaserecord")]
        public MicrosoftDynamicsCRMknowledgebaserecord ObjectidKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_account")]
        public MicrosoftDynamicsCRMaccount ObjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_list")]
        public MicrosoftDynamicsCRMlist ObjectidList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaignresponse")]
        public MicrosoftDynamicsCRMcampaignresponse ObjectidCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_kbarticle")]
        public MicrosoftDynamicsCRMkbarticle ObjectidKbarticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity ObjectidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Annotation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AnnotationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_sla")]
        public MicrosoftDynamicsCRMsla ObjectidSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_calendar")]
        public MicrosoftDynamicsCRMcalendar ObjectidCalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_fax")]
        public MicrosoftDynamicsCRMfax ObjectidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_incidentresolution")]
        public MicrosoftDynamicsCRMincidentresolution ObjectidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_contact")]
        public MicrosoftDynamicsCRMcontact ObjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_letter")]
        public MicrosoftDynamicsCRMletter ObjectidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_service")]
        public MicrosoftDynamicsCRMservice ObjectidService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_salesorder")]
        public MicrosoftDynamicsCRMsalesorder ObjectidSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_quoteclose")]
        public MicrosoftDynamicsCRMquoteclose ObjectidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_competitor")]
        public MicrosoftDynamicsCRMcompetitor ObjectidCompetitor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_contract")]
        public MicrosoftDynamicsCRMcontract ObjectidContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_goal")]
        public MicrosoftDynamicsCRMgoal ObjectidGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_task")]
        public MicrosoftDynamicsCRMtask ObjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_orderclose")]
        public MicrosoftDynamicsCRMorderclose ObjectidOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_workflow")]
        public MicrosoftDynamicsCRMworkflow ObjectidWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_incident")]
        public MicrosoftDynamicsCRMincident ObjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_equipment")]
        public MicrosoftDynamicsCRMequipment ObjectidEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_contractdetail")]
        public MicrosoftDynamicsCRMcontractdetail ObjectidContractdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaign")]
        public MicrosoftDynamicsCRMcampaign ObjectidCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Annotation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AnnotationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_lead")]
        public MicrosoftDynamicsCRMlead ObjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_mailbox")]
        public MicrosoftDynamicsCRMmailbox ObjectidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ObjectidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_resourcespec")]
        public MicrosoftDynamicsCRMresourcespec ObjectidResourcespec { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_duplicaterule")]
        public MicrosoftDynamicsCRMduplicaterule ObjectidDuplicaterule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Annotation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AnnotationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment ObjectidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_quote")]
        public MicrosoftDynamicsCRMquote ObjectidQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_invoice")]
        public MicrosoftDynamicsCRMinvoice ObjectidInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ObjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_emailserverprofile")]
        public MicrosoftDynamicsCRMemailserverprofile ObjectidEmailserverprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_opportunityclose")]
        public MicrosoftDynamicsCRMopportunityclose ObjectidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_product")]
        public MicrosoftDynamicsCRMproduct ObjectidProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity ObjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ObjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMabsScheduledprocessexecution ObjectidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_agencycommunication")]
        public MicrosoftDynamicsCRMadoxioAgencycommunication ObjectidAdoxioAgencycommunication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication ObjectidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_complaint")]
        public MicrosoftDynamicsCRMadoxioComplaint ObjectidAdoxioComplaint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_investigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation ObjectidAdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_licences")]
        public MicrosoftDynamicsCRMadoxioLicences ObjectidAdoxioLicences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_localgovindigenousnation")]
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation ObjectidAdoxioLocalgovindigenousnation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_worker")]
        public MicrosoftDynamicsCRMadoxioWorker ObjectidAdoxioWorker { get; set; }

    }
}
