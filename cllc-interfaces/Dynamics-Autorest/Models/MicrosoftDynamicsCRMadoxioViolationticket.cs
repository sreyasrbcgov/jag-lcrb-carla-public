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
    /// Microsoft.Dynamics.CRM.adoxio_violationticket
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioViolationticket
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationticket class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationticket()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationticket class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationticket(string adoxioEstablishment = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? adoxioViolationticketstatuses = default(int?), string adoxioInspector = default(string), int? statecode = default(int?), System.DateTimeOffset? newCourtdate = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioFineamount = default(string), string _owneridValue = default(string), string adoxioVtcourthouselocation = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), string versionnumber = default(string), int? newViolationticketnumber = default(int?), int? utcconversiontimezonecode = default(int?), string adoxioViolationticketid = default(string), int? newInspectors = default(int?), System.DateTimeOffset? adoxioDateofservice = default(System.DateTimeOffset?), string _owningteamValue = default(string), bool? adoxioProvenunproven = default(bool?), string _createdbyValue = default(string), System.DateTimeOffset? adoxioDateofoffence = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? adoxioViolationtype = default(int?), string adoxioIndividualticketed = default(string), System.DateTimeOffset? adoxioDatevtsenttoicbc = default(System.DateTimeOffset?), string adoxioRegion = default(string), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string newFinalfineamount = default(string), string _owninguserValue = default(string), string adoxioRm = default(string), string adoxioArea = default(string), string _createdonbehalfbyValue = default(string), string adoxioPostalcode = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> adoxioViolationticketActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> adoxioViolationticketAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> adoxioViolationticketSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationticketDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationticketDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioViolationticketSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioViolationticketAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioViolationticketMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioViolationticketProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioViolationticketBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioViolationticketPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> adoxioViolationticketAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioViolationticketEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioViolationticketFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioViolationticketLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioViolationticketPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> adoxioViolationticketTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioViolationticketRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioViolationticketSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMqueueitem> adoxioViolationticketQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> adoxioViolationticketAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioViolationticketServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>))
        {
            AdoxioEstablishment = adoxioEstablishment;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            AdoxioViolationticketstatuses = adoxioViolationticketstatuses;
            AdoxioInspector = adoxioInspector;
            Statecode = statecode;
            NewCourtdate = newCourtdate;
            Overriddencreatedon = overriddencreatedon;
            AdoxioFineamount = adoxioFineamount;
            this._owneridValue = _owneridValue;
            AdoxioVtcourthouselocation = adoxioVtcourthouselocation;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            NewViolationticketnumber = newViolationticketnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioViolationticketid = adoxioViolationticketid;
            NewInspectors = newInspectors;
            AdoxioDateofservice = adoxioDateofservice;
            this._owningteamValue = _owningteamValue;
            AdoxioProvenunproven = adoxioProvenunproven;
            this._createdbyValue = _createdbyValue;
            AdoxioDateofoffence = adoxioDateofoffence;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioViolationtype = adoxioViolationtype;
            AdoxioIndividualticketed = adoxioIndividualticketed;
            AdoxioDatevtsenttoicbc = adoxioDatevtsenttoicbc;
            AdoxioRegion = adoxioRegion;
            Statuscode = statuscode;
            Createdon = createdon;
            NewFinalfineamount = newFinalfineamount;
            this._owninguserValue = _owninguserValue;
            AdoxioRm = adoxioRm;
            AdoxioArea = adoxioArea;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioPostalcode = adoxioPostalcode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioViolationticketActivityPointers = adoxioViolationticketActivityPointers;
            AdoxioViolationticketAbsScheduledprocessexecutions = adoxioViolationticketAbsScheduledprocessexecutions;
            AdoxioViolationticketSyncErrors = adoxioViolationticketSyncErrors;
            AdoxioViolationticketDuplicateMatchingRecord = adoxioViolationticketDuplicateMatchingRecord;
            AdoxioViolationticketDuplicateBaseRecord = adoxioViolationticketDuplicateBaseRecord;
            AdoxioViolationticketSharePointDocumentLocations = adoxioViolationticketSharePointDocumentLocations;
            AdoxioViolationticketAsyncOperations = adoxioViolationticketAsyncOperations;
            AdoxioViolationticketMailboxTrackingFolders = adoxioViolationticketMailboxTrackingFolders;
            AdoxioViolationticketProcessSession = adoxioViolationticketProcessSession;
            AdoxioViolationticketBulkDeleteFailures = adoxioViolationticketBulkDeleteFailures;
            AdoxioViolationticketPrincipalObjectAttributeAccesses = adoxioViolationticketPrincipalObjectAttributeAccesses;
            AdoxioViolationticketAppointments = adoxioViolationticketAppointments;
            AdoxioViolationticketEmails = adoxioViolationticketEmails;
            AdoxioViolationticketFaxes = adoxioViolationticketFaxes;
            AdoxioViolationticketLetters = adoxioViolationticketLetters;
            AdoxioViolationticketPhoneCalls = adoxioViolationticketPhoneCalls;
            AdoxioViolationticketTasks = adoxioViolationticketTasks;
            AdoxioViolationticketRecurringAppointmentMasters = adoxioViolationticketRecurringAppointmentMasters;
            AdoxioViolationticketSocialActivities = adoxioViolationticketSocialActivities;
            AdoxioViolationticketQueueItems = adoxioViolationticketQueueItems;
            AdoxioViolationticketAnnotations = adoxioViolationticketAnnotations;
            AdoxioViolationticketServiceAppointments = adoxioViolationticketServiceAppointments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment")]
        public string AdoxioEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticketstatuses")]
        public int? AdoxioViolationticketstatuses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inspector")]
        public string AdoxioInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_courtdate")]
        public System.DateTimeOffset? NewCourtdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fineamount")]
        public string AdoxioFineamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_vtcourthouselocation")]
        public string AdoxioVtcourthouselocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_violationticketnumber")]
        public int? NewViolationticketnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticketid")]
        public string AdoxioViolationticketid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_inspectors")]
        public int? NewInspectors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofservice")]
        public System.DateTimeOffset? AdoxioDateofservice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_provenunproven")]
        public bool? AdoxioProvenunproven { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofoffence")]
        public System.DateTimeOffset? AdoxioDateofoffence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationtype")]
        public int? AdoxioViolationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_individualticketed")]
        public string AdoxioIndividualticketed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datevtsenttoicbc")]
        public System.DateTimeOffset? AdoxioDatevtsenttoicbc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_region")]
        public string AdoxioRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_finalfineamount")]
        public string NewFinalfineamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rm")]
        public string AdoxioRm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area")]
        public string AdoxioArea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_postalcode")]
        public string AdoxioPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioViolationticketActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AdoxioViolationticketAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioViolationticketSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationticketDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationticketDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioViolationticketSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioViolationticketAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioViolationticketMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioViolationticketProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioViolationticketBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioViolationticketPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioViolationticketAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioViolationticketEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioViolationticketFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioViolationticketLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioViolationticketPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioViolationticketTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioViolationticketRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioViolationticketSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> AdoxioViolationticketQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioViolationticketAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationticket_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioViolationticketServiceAppointments { get; set; }

    }
}
