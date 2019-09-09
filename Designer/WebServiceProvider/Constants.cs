using System.Collections.Generic;

namespace Design.WebServiceProvider
{
    public class Constants
    {
        public const int VIEW_EHS_LIVE_BUILD_NUMBER = 4;
        public const string VIEW_EHS_LIVE_VERSION_NUMBER = "1.3";

        public const int VIEW_EHS_WET_LIVE_BUILD_NUMBER = 5;
        public const string VIEW_EHS_WET_LIVE_VERSION_NUMBER = "1.4";

        public static List<string> RISK_TYPES = new List<string> { "Select Risk Type", "Very High Risk/Impact", "High Risk/Impact", "Medium Risk/Impact", "Low Risk/Impact" };

        /***********ACTION Strings************************/
        //public const string ADD_ACTION = "Add";
        /********************************************/

        /******************* Android Details ******************/
        public const string ANDROID_OS_NAME = "ANDROID";

        // UI Screen
        // CheckList Screen
        public const string OK_TEXT = "Ok";
        public const string CANCEL_TEXT = "Cancel";

        // Incident FRagment

        // Osbervation 

        //common
        public const string SUCCESS_TEXT = "success";
        public const string DATE_FORMAT_FOR_CHECKLIST = "dd MMM yyy,hh:mm tt";
        public const string HASH = "#";
        public const string ENETER_COMMENT_AND_THEN_POST = "Enter comment and post";
        public const string PICK_PICTURE_TEXT = "Pick Picture";
        public const string DRAFTS_TEXT = "Drafts";
        public const string DRAFT_TEXT = "Draft";
        public const string NO_OBJECTIVE_Text = "No objective";
        public const string NO_KPI_TEXT = "No kpi";
        public const string SUBMITTED_TEXT = "Submitted";
        public const string PENDING_TEXT = "Pending";
        public const string FORMS_TEXT = "Forms";
        public const string APPROVE_TEXT = "Approve";
        public const string REJECT_TEXT = "Reject";
        public const string EXPIRED_TEXT = "Expire";
        public const string APPROVED_TEXT = "Approved";
        public const string REJECTED_TEXT = "Rejected";
        public const string TO_BE_APPROVED_TEXT = "To be Approved";
        public const string CLOSED_TEXT = "Closed";
        public const string TO_BE_CLOSED_TEXT = "To be Closed";
        public const string OBSERVATION_TEXT = "Observation";
        public const string INCIDENT_TEXT = "Incident Report";
        public const string MORE_TEXT = "More";
        public const string CHECKLIST_TEXT = "Checklist";
        public const string DASHBOARD_TEXT = "Dashboard";
        public const string COMMENT_TEXT = "Comment";
        public const string API_DATE_FORMAT = "yyyy-MM-dd";
        public const string SUBMIT_TEXT = "Submit";
        public const string NEXT_TEXT = "Next";
        public const string SEC_FORM_GROUP_NAME = "SEC";
        public const string DOT = ".";

        public const int IMAGE_UPLOAD_LIMIT = 3;

        public const int ICID_FOR_CATEGORY_BASED_ACTIVITIES = 10;

        // ROLE IDs
        public const int SITE_EHS_ROLE_ID = 2;
        public const int SITE_ENGINEER_ROLE_ID = 5;
        public const int SECTION_INCHARGE_ROLE_ID = 4;

        /******* KeyStore Details *************/
        public const string KEYSTORE_PASSWORD = "safearmz";
        public const string KEY_ALIAS = "safearmz";
        public const string KEY_ALIAS_PASSWORD = "safearmz";
        /*******************/

        // Font path
        public const string FONT_PATH_BOLD = "Fonts/roboto_bold.ttf";
        public const string FONT_PATH_MEDIUM = "Fonts/roboto_medium.ttf";
        public const string FONT_PATH_REGULAR = "Fonts/roboto_regular.ttf";

        /***************************************************/

    }

    public class Urls
    {
        //public const string ENVIRONMENT = "DEV";
        //public const string ENVIRONMENT = "LIVE";
        //public const string ENVIRONMENT = "View Ehs Dev";
        //public const string ENVIRONMENT = "Wet Dev";
        //public const string ENVIRONMENT = "Wet Dev Performance"; 
        //public const string ENVIRONMENT = "View Ehs Live";
        public const string ENVIRONMENT = "Wet Live";

        /***********URL STRINGS *********************/
        public static string LOGIN_URL = GetBaseUrl() + "account/login";
        public static string FORGOT_PWD_URL = GetBaseUrl() + "account/forgotPassword";
        public static string CHANGE_PWD_URL = GetBaseUrl() + "account/changepassword";

        public static string DOCUMENT_GROUP_URL = GetBaseUrl() + "project/getDocumentGroupList";
        public static string ACTIVITY_SUBACTIVITY_URL = GetBaseUrl() + "project/getActivityList";
        public static string SUBACTIVITY_DETAIL_URL = GetBaseUrl() + "project/getSubActivityLists";
        public static string SUBACTIVITY_DETAIL_WET_URL = GetBaseUrl() + "project/getSubActivityListsWET";
        //public static string CHECKLIST_INFO_URL = GetBaseUrl() + "project/getChecklistInformation";
        public static string GET_CHECKLIST_NEW_URL = GetBaseUrl() + "Project/getChecklistInformationNew";
        public static string GET_CHECKLIST_QUESTIONS_URL = GetBaseUrl() + "Project/getChecklistQuestions";

        public static string FORMS_LIST_URL = GetBaseUrl() + "project/getFormList";
        public static string FORM_DETAILS_URL = GetBaseUrl() + "project/getformDetails";
        public static string SUBMIT_FORM_URL = GetBaseUrl() + "project/submitForm";
        public static string IMAGE_UPLOAD_URL = GetBaseUrl() + "project/Upload";
        public static string POST_COMMENT_URL = GetBaseUrl() + "project/postComments";
        public static string GET_OBSERVATION_LIST_URL = GetBaseUrl() + "project/getObservationList";
        public static string POST_COMMENT_FOR_OBSERVATION_URL = GetBaseUrl() + "project/observationComments";
        public static string GET_USER_LIST_URL = GetBaseUrl() + "account/getUserList";
        public static string SUBMIT_OBSERVATION_URL = GetBaseUrl() + "project/submitObservation";
        public static string GET_INCIDENT_LIST = GetBaseUrl() + "project/getIncidentList";
        public static string SUBMIT_INCIDENT_URL = GetBaseUrl() + "project/submitIncident";
        public static string GET_PROJECT_REPORT_URL = GetBaseUrl() + "project/getProjectReport";
        public static string GET_NOTFICATION_LIST_URL = GetBaseUrl() + "project/getNotificationList";
        public static string GET_PROJECT_LIST_URL = GetBaseUrl() + "project/getUserProjectList";
        public static string APPROVE_FORM_URL = GetBaseUrl() + "project/approveForm";
        public static string REJECT_FORM_URL = GetBaseUrl() + "project/rejectForm";
        public static string GET_CATEGORY_BASED_ACTIVITYLIST = GetBaseUrl() + "/project/getActivityListWET";
        public static string GET_OBSERVATION_ACTIVITY_SUBACTIVITY_URL = GetBaseUrl() + "project/getObservationActivityList";
        public static string FileSystemFolderName = "ScoreCard/Images";

        private static string GetBaseUrl()
        {
            if (ENVIRONMENT == "DEV")
            {
                return "http://api.scorecardapp.tk/";

            }
            else if (ENVIRONMENT == "LIVE")
            {
                return "http://liveapi.scorecard.hakunamatata.io/";
            }
            else if (ENVIRONMENT == "View Ehs Dev")
            {
                //return "http://52.172.177.4/ViewEHSApiDev/"; 
                return "http://52.172.219.33/ViewEHSSWCAPI_Dev/";
            }
            else if (ENVIRONMENT == "Wet Dev")
            {
                //return "http://52.172.177.4/ViewEHSWETAPI/";
                return "http://52.172.219.33/ViewEHSWETAPI_Dev/";
            }
            else if (ENVIRONMENT == "Wet Dev Performance")
            {
                return "http://52.172.219.33/ViewEHSWETAPI/";
            }
            else if (ENVIRONMENT == "View Ehs Live")
            {
                return "https://safety.digital.lntecc.com/ViewEHSApi/";
            }
            else if (ENVIRONMENT == "Wet Live")
            {
                return "https://safety.digital.lntecc.com/ViewEHSWETApi/";
            }
            //return null;
        }
    }

    public class ApiParams
    {

    }

    public class ApiHeaders
    {
        /*********** Login Headers ************************/

        public const string USER_HDR_PARAM_KEY = "userID";
        public const string USER_NAME_PARAM_KEY = "username";
        public const string PASSWORD_PARAM_KEY = "password";
        public const string DEVICE_ID_PARAM_KEY = "deviceID";
        public const string OS_NAME_PARAM_KEY = "osName";
        public const string OS_VERSION_PARAM_KEY = "osVersion";
        public const string MODEL_NAME_PARAM_KEY = "modelName";
        public const string DEVICE_TOKEN_PARAM_KEY = "deviceToken";
        public const string FILE_DATA_PARAM_KEY = "fileData";
        public const string SOURCE_HDR_PARAM_KEY = "source";
        public const string SESSION_HDR_PARAM_KEY = "sessionToken";
        public const string AUTHORIZATION_HDR_PARAM_KEY = "Authorization";

        /********************************************/

        public const string SOURCE_VALUE = "Mobile";
    }

    public class StatusCodes
    {
        public const int SUCCESS_STATUS_CODE = 200;
    }

    public class WarningMessages
    {

    }

    public class AlertMessages
    {
        // CheckList Screen
        public const string IMAGE_UPLOAD_LIMIT_Message = "You reached the image upload Limit";
        public const string ALLOW_CAMERA_SETTINGS_MESSAGE = "Allow camera access option for this Application.";
        public const string ARE_YOU_SURE_WANT_TO_EXIT_ALERT = "Are you sure want to exit ?";
        //public const string ALL_THE_FILLED_ANSWERS_WILL_BE_ERASED = \"Filled answers will be erased.\";

        public const string SAVED_INTO_DRAFT = "Saved into Draft.";
        public const string CHANGES_WILL_BE_ERASED = "Save into draft, Otherwise changes will be erased";
        public const string No_FORM_DETAIL_ALERT = "No Form Detail is Available.";
        public const string LOCATION_NEEDED_ALERT = "Please Enter Location";
        public const string HAZARD_NEEDED_ALERT = "Please Choose atleast One Hazard Type";
        public const string RISK_NEEDED_ALERT = "Please Select Risk Type";
        public const string SECTION_INCHARGE_NEEDED_ALERT = "Please Select Section Incharge";
        public const string SIGNATURE_NEEDED_ALERT = "Please Sign and then Submit";
        public const string CHOOSE_SUBACTIVITY_ALERT = "Please select SubActivity or deselect Activity";
        public const string NEEDED_IN_RCCB_NUMBER_ALERT = "Please Enter Rccb Number";
        public const string SOURCE_NEEDED_ALERT = "Please Choose Source Field";

        //public const string NUMERIC_VALUE_NEEDED_IN_RCCB_NUMBER = "Please Enter only numeric value in Rccb No field";

        public const string DECIMAL_VALUE_NEEDED_IN_RESISTANCE_NUMBER = "Please Enter only Decimal value in Resistance field";
        public const string TESTING_DATE_NEEDED_ALERT = "Please select Testing Date";
        public const string RESISTANCE_NEEDED_ALERT = "Please Enter Resistance Value";
        public const string SENSITIVITY_NEEDED_ALERT = "Please Enter Sensitivity Value";
        public const string EQUIPMENT_DETAILS_NEEDED_ALERT = "Please Enter Equipment Details Value";
        public const string STATUS_NEEDED_ALERT = "Please select any one status";
        public const string ATLEAST_ONE_NEEDED_IN_LIST = "Please Add Atleast One Item in List";
        public const string FILL_MANDATORY_QUESTIONS_ALERT = "Please fill all mandatory questions and then re-submit";
        public const string FILL_ANYTHING_ALERT = "Fill anything and then submit";
        public const string ATLEAST_ONE_RCCB_NEEDED = "Please add atleast one Rccb";
        public const string ATLEAST_ONE_FIRE_EXTINGUISHER_NEEDED = "Please add atleast one Fire Extinguisher Type";
        public const string URL_EMPTY = "Empty Url";
        public const string URL_NOT_AVAILABLE = "Url Not Available";

        // More Frament
        public const string PROJECT_LIST_EMPTY = "Project List Not Available";

        // login
        public const string ENTER_USER_ID_AND_PASSWORD_ALERT = "Enter User Id and Password";
        public const string INVALID_USER_ID_ALERT = "Invalid User ID or Password";

        // New Incident Submission Screen
        public const string SELECT_TYPE_OF_INCIDENT = "Please Select Type of Incident";
        public const string ENTER_NUMERIC_VALUE_IN_PERSONS_AFFECTED_FIELD = "Please Enter only numeric value in persons affected field";

        //Dashboard
        public const string PROJECT_NOT_MAPPED = "Project Not Mapped";

        // common 
        public const string SWITCH_ON_STORAGE_ACCESS_MESSAGE = "Switch On the storage Access in app permission.";
        public const string NETWORK_PROBLEM_MESSAGE = "Network Problem couldn't get Geo Co-ordinates.";
        public const string ALLOW_GPS_MESSAGE = "Allow Gps access option for this Application.";
        public const string NEED_TO_FILL_MANDTORY_FIELDS_ALERT = "Please fill all mandatory questions and then re-submit.";
        public const string SIGNATURE_URL_NEEDED_ALERT = "Signature Image Url Missing or Signature Image not uploaded in Server";
        public const string CHECKLIST_NOT_AVAILABLE = "This Checklist is not Available";
        public static string ALREADY_EXISTS = "Already Exists";
        public static string INTERNET_CONNECTION = "Please check your internet connection";
        public const string NO_NETWORK_CONNECTION = "No Network Available";
        public const string ENTER_COMMENT_ALERT = "Please Enter Comment";
        public const string CHOOSE_SITE_EHS_ALERT = "Please Choose Site EHS";
        public const string SITE_EHS_HINT = "Select Site EHS";
        public const string NOTHING_ANSWERED_ALERT = "Nothing is Answered Now";
        public const string FORM_DETAIL_NOT_AVAILABLE = "Form Detail is Not Available";
        public const string FORM_NOT_APPLICABLE_FOR_THIS_USER = "This Form not applicable for this user.";
    }
}