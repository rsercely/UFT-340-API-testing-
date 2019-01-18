/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘APIWADL_GetFlights.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir9 = null;
        public BindDirection bind_dir10 = null;
        public BindDirection bind_dir11 = null;
        public BindDirection bind_dir12 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence8 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence8");
            _flow.RESTActivityV27 = new HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV27Input,RESTActivityV27Output>(_context,"RESTActivityV27");
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence8);
            this.Activities.Add (_flow.Loop2);
            XmlDocument EndActivity3_ExecutionOutputParameters_Document = new XmlDocument();
            EndActivity3_ExecutionOutputParameters_Document.PreserveWhitespace = true;
            EndActivity3_ExecutionOutputParameters_Document.LoadXml(
@"<Arguments><FlightNo>{Step.ResponseXmlBody.RESTActivityV27.Flight[1].FlightNumber}</FlightNo></Arguments>");
            _flow.EndActivity3.ExecutionOutputParameters = EndActivity3_ExecutionOutputParameters_Document;
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            VTDPropertyInfoBase pi17 = new VTDPropertyInfoBase("XMLResponse","/*[local-name(.)='ArrayOfFlight'][1]/*[local-name(.)='Flight'][{Array0}]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseGetter binding_getter9 = new VTDXPathGetter(pi17,XmlTypeCode.UnsignedShort);
            binding_getter9 = new XPathGetterDecorator(binding_getter9,"{Array0}",1);
            VTDPropertyInfoBase pi18 = new VTDPropertyInfoBase("ExecutionOutputParameters","/*[local-name(.)='Arguments'][1]/*[local-name(.)='FlightNo'][1]");
            VTDBaseSetter binding_setter9 = new VTDXPathSetter(pi18,XmlTypeCode.Int);
            bind_dir9 = new BindDirection(_flow.RESTActivityV27,binding_getter9,binding_setter9,BindTargetType.ToInProperty);
            _flow.EndActivity3.InDirections.Add(bind_dir9);
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence8.Comment = @"";
            _flow.Sequence8.IconPath = @"";
            _flow.Sequence8.Name = @"Sequence8";
            _flow.Sequence8.Activities.Add (_flow.RESTActivityV27);
            _flow.RESTActivityV27.TextBody = @"";
            _flow.RESTActivityV27.TextXmlBody = @"";
            _flow.RESTActivityV27.FileBody = @"";
            _flow.RESTActivityV27.PostBody = @"";
            _flow.RESTActivityV27.Url = @"http://localhost:8000/HPFlights_REST/Flights?DepartureCity={Step.RESTInputProperties.RESTActivityV27.DepartureCity}&ArrivalCity={Step.RESTInputProperties.RESTActivityV27.ArrivalCity}&Date={Step.RESTInputProperties.RESTActivityV27.Date}";
            _flow.RESTActivityV27.HttpMethod = @"GET";
            _flow.RESTActivityV27.HttpVersion = @"1.1";
            _flow.RESTActivityV27.Input.DepartureCity = @"London";
            _flow.RESTActivityV27.Input.ArrivalCity = @"Paris";
            _flow.RESTActivityV27.Input.Date =  new DateTime(2111,12,11,0,0,0,0);
            _flow.RESTActivityV27.Comment = @"";
            _flow.RESTActivityV27.IconPath = @"AddIns\ServiceTest\REST\ictb_REST_Method_16.png";
            _flow.RESTActivityV27.RequestBodyType = @"Text";
            _flow.RESTActivityV27.ResponseType = @"Xml";
            _flow.RESTActivityV27.Name = @"GetFlights7";
            _flow.RESTActivityV27.Proxy.Server = @"";
            _flow.RESTActivityV27.Proxy.Username = @"";
            _flow.RESTActivityV27.Proxy.Password = @"";
            _flow.RESTActivityV27.Authentication.Username = @"";
            _flow.RESTActivityV27.Authentication.Password = @"";
            _flow.RESTActivityV27.Authentication.PreemptiveAuthentication = false;
            _flow.RESTActivityV27.ConnectionType = @"Keep-Alive";
            _flow.RESTActivityV27.Timeout = (int)100000;
            _flow.RESTActivityV27.ClientCertificate.Password = @"";
            _flow.RESTActivityV27.ClientCertificate.FileSystem.Path = @"";
            _flow.RESTActivityV27.UseClientCertificate = false;
            _flow.RESTActivityV27.MaximumAutomaticRedirections = (int)3;
            _flow.RESTActivityV27.AllowRedirections = true;
            _flow.RESTActivityV27.ReuseCookies = false;
            _flow.RESTActivityV27.ExpectServerError = false;
            _flow.RESTActivityV27.HanaRequest = false;
            XmlDocument RESTActivityV27_XMLBody_Document = new XmlDocument();
            RESTActivityV27_XMLBody_Document.PreserveWhitespace = true;
            RESTActivityV27_XMLBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.RESTActivityV27.XMLBody = RESTActivityV27_XMLBody_Document;
            XmlDocument RESTActivityV27_RequestMultipartInfoXml_Document = new XmlDocument();
            RESTActivityV27_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            RESTActivityV27_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.RESTActivityV27.RequestMultipartInfoXml = RESTActivityV27_RequestMultipartInfoXml_Document;
            _flow.RESTActivityV27.Multipart=false;
            _flow.RESTActivityV27.Input.DepartureCity = @"London";
            _flow.RESTActivityV27.Input.ArrivalCity = @"Paris";
            _flow.RESTActivityV27.Input.Date =  new DateTime(2111,12,11,0,0,0,0);
            _flow.RESTActivityV27.Input.DepartureCity = @"London";
            _flow.RESTActivityV27.Input.ArrivalCity = @"Paris";
            _flow.RESTActivityV27.Input.Date =  new DateTime(2111,12,11,0,0,0,0);
            VTDPropertyInfoBase pi19 = new VTDPropertyInfoBase("Input.DepartureCity");
            VTDBaseGetter binding_getter10 = new VTDObjectGetter(pi19);
            VTDPropertyInfoBase pi20 = new VTDPropertyInfoBase("Url");
            VTDBaseSetter binding_setter10 = new VTDObjectSetter(pi20);
            binding_setter10 = new StringFormaterDecorator(binding_setter10,"{Step.RESTInputProperties.RESTActivityV27.DepartureCity}");
            bind_dir10 = new BindDirection(_flow.RESTActivityV27,binding_getter10,binding_setter10,BindTargetType.ToInProperty);
            _flow.RESTActivityV27.InDirections.Add(bind_dir10);
            VTDPropertyInfoBase pi21 = new VTDPropertyInfoBase("Input.ArrivalCity");
            VTDBaseGetter binding_getter11 = new VTDObjectGetter(pi21);
            VTDPropertyInfoBase pi22 = new VTDPropertyInfoBase("Url");
            VTDBaseSetter binding_setter11 = new VTDObjectSetter(pi22);
            binding_setter11 = new StringFormaterDecorator(binding_setter11,"{Step.RESTInputProperties.RESTActivityV27.ArrivalCity}");
            bind_dir11 = new BindDirection(_flow.RESTActivityV27,binding_getter11,binding_setter11,BindTargetType.ToInProperty);
            _flow.RESTActivityV27.InDirections.Add(bind_dir11);
            VTDPropertyInfoBase pi23 = new VTDPropertyInfoBase("Input.Date");
            VTDBaseGetter binding_getter12 = new VTDObjectGetter(pi23);
            VTDPropertyInfoBase pi24 = new VTDPropertyInfoBase("Url");
            VTDBaseSetter binding_setter12 = new VTDObjectSetter(pi24);
            binding_setter12 = new StringFormaterDecorator(binding_setter12,"{Step.RESTInputProperties.RESTActivityV27.Date}");
            bind_dir12 = new BindDirection(_flow.RESTActivityV27,binding_getter12,binding_setter12,BindTargetType.ToInProperty);
            _flow.RESTActivityV27.InDirections.Add(bind_dir12);
            XmlDocument RESTActivityV27_ExpectedResponseXmlBody_Document = new XmlDocument();
            RESTActivityV27_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            RESTActivityV27_ExpectedResponseXmlBody_Document.LoadXml(
@"<ArrayOfFlight xmlns=""HP.SOAQ.SampleApp"" xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"">
  <Flight>
    <Airline>AA</Airline>
    <ArrivalCity>Sydney</ArrivalCity>
    <ArrivalTime>04:23 PM</ArrivalTime>
    <DepartureCity>Portland</DepartureCity>
    <DepartureTime>09:12 AM</DepartureTime>
    <FlightNumber>20226</FlightNumber>
    <Price>112.2</Price>
  </Flight>
  <Flight>
    <Airline>AA</Airline>
    <ArrivalCity>Sydney</ArrivalCity>
    <ArrivalTime>01:23 PM</ArrivalTime>
    <DepartureCity>Portland</DepartureCity>
    <DepartureTime>06:12 AM</DepartureTime>
    <FlightNumber>20230</FlightNumber>
    <Price>112.2</Price>
  </Flight>
</ArrayOfFlight>");
            _flow.RESTActivityV27.ExpectedResponseXmlBody = RESTActivityV27_ExpectedResponseXmlBody_Document;
            XmlDocument RESTActivityV27_ExpectedResponseJsonBody_Document = new XmlDocument();
            RESTActivityV27_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            RESTActivityV27_ExpectedResponseJsonBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.RESTActivityV27.ExpectedResponseJsonBody = RESTActivityV27_ExpectedResponseJsonBody_Document;
            XmlDocument RESTActivityV27_ExpectedOutputProperties_Document = new XmlDocument();
            RESTActivityV27_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            RESTActivityV27_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion></ResponseHttpVersion><StatusCode></StatusCode><StatusDescription></StatusDescription><ResponseBody></ResponseBody><ResponseBodyAsBase64></ResponseBodyAsBase64></Arguments>");
            _flow.RESTActivityV27.ExpectedOutputProperties = RESTActivityV27_ExpectedOutputProperties_Document;
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    