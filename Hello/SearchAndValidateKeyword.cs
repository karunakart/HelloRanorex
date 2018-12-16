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

namespace Hello
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchAndValidateKeyword recording.
    /// </summary>
    [TestModule("a1e8603e-0403-4c6c-8a1c-27eac8d81b7f", ModuleType.Recording, 1)]
    public partial class SearchAndValidateKeyword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HelloRepository repository.
        /// </summary>
        public static HelloRepository repo = HelloRepository.Instance;

        static SearchAndValidateKeyword instance = new SearchAndValidateKeyword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchAndValidateKeyword()
        {
            sk = "hello";
            searchedvalues = "";
            ResultStats = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchAndValidateKeyword Instance
        {
            get { return instance; }
        }

#region Variables

        string _searchedvalues;

        /// <summary>
        /// Gets or sets the value of variable searchedvalues.
        /// </summary>
        [TestVariable("30619e37-d49e-4fc4-ac21-054cca1c5130")]
        public string searchedvalues
        {
            get { return _searchedvalues; }
            set { _searchedvalues = value; }
        }

        string _ResultStats;

        /// <summary>
        /// Gets or sets the value of variable ResultStats.
        /// </summary>
        [TestVariable("47d22ecd-c4d0-4b3a-8536-c7a6a5b09598")]
        public string ResultStats
        {
            get { return _ResultStats; }
            set { _ResultStats = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable sk.
        /// </summary>
        [TestVariable("835187d5-8588-4569-ac93-5c7a1fda6942")]
        public string sk
        {
            get { return repo.sk; }
            set { repo.sk = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(0));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$sk' with focus on 'Google.SearchField'.", repo.Google.SearchFieldInfo, new RecordItemIndex(1));
            repo.Google.SearchField.PressKeys(sk);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Google.SearchField'.", repo.Google.SearchFieldInfo, new RecordItemIndex(2));
            repo.Google.SearchField.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Google.SearchButton' at 93;23.", repo.Google.SearchButtonInfo, new RecordItemIndex(3));
            repo.Google.SearchButton.Click("93;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.ResultStats' and assigning its value to variable 'ResultStats'.", repo.Google.ResultStatsInfo, new RecordItemIndex(4));
            ResultStats = repo.Google.ResultStats.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ResultStats, new RecordItemIndex(5));
            
            TimeCollection.UpdateInputFile("results", ResultStats);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", searchedvalues, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}