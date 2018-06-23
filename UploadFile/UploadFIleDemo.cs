﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace UploadFile
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UploadFIleDemo recording.
    /// </summary>
    [TestModule("4475b32c-14a6-4ec8-9eca-1fdb654b21ea", ModuleType.Recording, 1)]
    public partial class UploadFIleDemo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UploadFileRepository repository.
        /// </summary>
        public static UploadFileRepository repo = UploadFileRepository.Instance;

        static UploadFIleDemo instance = new UploadFIleDemo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UploadFIleDemo()
        {
            sk = "";
            FilePath = "hellocsv.csv";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UploadFIleDemo Instance
        {
            get { return instance; }
        }

#region Variables

        string _sk;

        /// <summary>
        /// Gets or sets the value of variable sk.
        /// </summary>
        [TestVariable("1bd8e7fd-4b91-4466-b02d-99b198a30c26")]
        public string sk
        {
            get { return _sk; }
            set { _sk = value; }
        }

        string _FilePath;

        /// <summary>
        /// Gets or sets the value of variable FilePath.
        /// </summary>
        [TestVariable("21bb1524-b571-4252-9bc7-04a6362c89cd")]
        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom1.
        /// </summary>
        [TestVariable("542dd990-feaf-45f9-a5a3-2b23347be2ae")]
        public string CustomerPortalDom1
        {
            get { return repo.CustomerPortalDom1; }
            set { repo.CustomerPortalDom1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom2.
        /// </summary>
        [TestVariable("fdb7f89b-f840-48e3-bfc3-92c10ea14357")]
        public string CustomerPortalDom2
        {
            get { return repo.CustomerPortalDom2; }
            set { repo.CustomerPortalDom2 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://encodable.com/uploaddemo/' with browser 'chrome' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://encodable.com/uploaddemo/", "chrome", "", false, true, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FileuploadPage.FIleuploadLInk' at Center.", repo.FileuploadPage.FIleuploadLInkInfo, new RecordItemIndex(1));
            repo.FileuploadPage.FIleuploadLInk.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hellocsv.csv' with focus on 'NewFolder.Open.Text1148'.", repo.NewFolder.Open.Text1148Info, new RecordItemIndex(2));
            repo.NewFolder.Open.Text1148.PressKeys("hellocsv.csv");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewFolder.Open.ButtonOpen' at 45;10.", repo.NewFolder.Open.ButtonOpenInfo, new RecordItemIndex(3));
            repo.NewFolder.Open.ButtonOpen.Click("45;10");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'ComEd'.", repo.ComEd.SelfInfo, new RecordItemIndex(4));
            //repo.ComEd.Self.WaitForDocumentLoaded();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ComEd.LnkBtnUploadNewBox' at 42;17.", repo.ComEd.LnkBtnUploadNewBoxInfo, new RecordItemIndex(5));
            //repo.ComEd.LnkBtnUploadNewBox.Click("42;17");
            //Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
