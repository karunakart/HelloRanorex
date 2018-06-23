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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Hello
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the HelloRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("798fb687-9336-4b77-9fc5-dfc140d651cd")]
    public partial class HelloRepository : RepoGenBaseFolder
    {
        static HelloRepository instance = new HelloRepository();
        HelloRepositoryFolders.GoogleAppFolder _google;
        HelloRepositoryFolders.HelloGoogleSearchGoogleChromeAppFolder _hellogooglesearchgooglechrome;

        /// <summary>
        /// Gets the singleton class instance representing the HelloRepository element repository.
        /// </summary>
        [RepositoryFolder("798fb687-9336-4b77-9fc5-dfc140d651cd")]
        public static HelloRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HelloRepository() 
            : base("HelloRepository", "/", null, 0, false, "798fb687-9336-4b77-9fc5-dfc140d651cd", ".\\RepositoryImages\\HelloRepository798fb687.rximgres")
        {
            _google = new HelloRepositoryFolders.GoogleAppFolder(this);
            _hellogooglesearchgooglechrome = new HelloRepositoryFolders.HelloGoogleSearchGoogleChromeAppFolder(this);
        }

#region Variables

        string _sk = "";

        /// <summary>
        /// Gets or sets the value of variable sk.
        /// </summary>
        [TestVariable("7a28c22e-e685-4e4e-9f67-d3640ffd14ea")]
        public string sk
        {
            get { return _sk; }
            set { _sk = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("798fb687-9336-4b77-9fc5-dfc140d651cd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Google folder.
        /// </summary>
        [RepositoryFolder("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
        public virtual HelloRepositoryFolders.GoogleAppFolder Google
        {
            get { return _google; }
        }

        /// <summary>
        /// The HelloGoogleSearchGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("a73cd204-2c4a-4d90-bb84-46eef95cd63c")]
        public virtual HelloRepositoryFolders.HelloGoogleSearchGoogleChromeAppFolder HelloGoogleSearchGoogleChrome
        {
            get { return _hellogooglesearchgooglechrome; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class HelloRepositoryFolders
    {
        /// <summary>
        /// The GoogleAppFolder folder.
        /// </summary>
        [RepositoryFolder("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
        public partial class GoogleAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _lstibInfo;
            RepoItemInfo _btnkInfo;
            RepoItemInfo _resultstatsInfo;

            /// <summary>
            /// Creates a new Google  folder.
            /// </summary>
            public GoogleAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Google", "/dom[@domain='www.google.com']", parentFolder, 30000, null, false, "5a1666c1-5747-4aef-a4d2-30c7aa95ee90", "")
            {
                _lstibInfo = new RepoItemInfo(this, "LstIb", ".//input[#'lst-ib']", 30000, null, "eec096b6-7342-4584-9f4c-5a727517cf48");
                _btnkInfo = new RepoItemInfo(this, "BtnK", ".//form[#'tsf']/div[2]//input[@name='btnK']", 30000, null, "99063f57-daf6-452f-bb95-39b56cda22d6");
                _resultstatsInfo = new RepoItemInfo(this, "ResultStats", ".//div[#'resultStats']", 30000, null, "6dc38630-323b-4a56-9174-998a7a004853");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LstIb item.
            /// </summary>
            [RepositoryItem("eec096b6-7342-4584-9f4c-5a727517cf48")]
            public virtual Ranorex.InputTag LstIb
            {
                get
                {
                    return _lstibInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LstIb item info.
            /// </summary>
            [RepositoryItemInfo("eec096b6-7342-4584-9f4c-5a727517cf48")]
            public virtual RepoItemInfo LstIbInfo
            {
                get
                {
                    return _lstibInfo;
                }
            }

            /// <summary>
            /// The BtnK item.
            /// </summary>
            [RepositoryItem("99063f57-daf6-452f-bb95-39b56cda22d6")]
            public virtual Ranorex.InputTag BtnK
            {
                get
                {
                    return _btnkInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The BtnK item info.
            /// </summary>
            [RepositoryItemInfo("99063f57-daf6-452f-bb95-39b56cda22d6")]
            public virtual RepoItemInfo BtnKInfo
            {
                get
                {
                    return _btnkInfo;
                }
            }

            /// <summary>
            /// The ResultStats item.
            /// </summary>
            [RepositoryItem("6dc38630-323b-4a56-9174-998a7a004853")]
            public virtual Ranorex.DivTag ResultStats
            {
                get
                {
                    return _resultstatsInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ResultStats item info.
            /// </summary>
            [RepositoryItemInfo("6dc38630-323b-4a56-9174-998a7a004853")]
            public virtual RepoItemInfo ResultStatsInfo
            {
                get
                {
                    return _resultstatsInfo;
                }
            }
        }

        /// <summary>
        /// The HelloGoogleSearchGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("a73cd204-2c4a-4d90-bb84-46eef95cd63c")]
        public partial class HelloGoogleSearchGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _hellogooglesearchInfo;
            RepoItemInfo _hellogooglesearchgooglechromeInfo;

            /// <summary>
            /// Creates a new HelloGoogleSearchGoogleChrome  folder.
            /// </summary>
            public HelloGoogleSearchGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("HelloGoogleSearchGoogleChrome", "/form[@title~'^hello\\ -\\ Google\\ Search\\ -\\ G']", parentFolder, 30000, null, true, "a73cd204-2c4a-4d90-bb84-46eef95cd63c", "")
            {
                _hellogooglesearchInfo = new RepoItemInfo(this, "HelloGoogleSearch", "container[@accessiblename~'^hello\\ -\\ Google\\ Search\\ -\\ G']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename='hello - Google Search']/text[@accessiblename='hello - Google Search']", 30000, null, "667a0d8b-ab3e-4cae-9864-5d42837e5ff9");
                _hellogooglesearchgooglechromeInfo = new RepoItemInfo(this, "HelloGoogleSearchGoogleChrome", "titlebar[@accessiblerole='TitleBar']", 30000, null, "f4a8d081-72a2-49d6-9f8c-c703303582bc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a73cd204-2c4a-4d90-bb84-46eef95cd63c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a73cd204-2c4a-4d90-bb84-46eef95cd63c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HelloGoogleSearch item.
            /// </summary>
            [RepositoryItem("667a0d8b-ab3e-4cae-9864-5d42837e5ff9")]
            public virtual Ranorex.Text HelloGoogleSearch
            {
                get
                {
                    return _hellogooglesearchInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The HelloGoogleSearch item info.
            /// </summary>
            [RepositoryItemInfo("667a0d8b-ab3e-4cae-9864-5d42837e5ff9")]
            public virtual RepoItemInfo HelloGoogleSearchInfo
            {
                get
                {
                    return _hellogooglesearchInfo;
                }
            }

            /// <summary>
            /// The HelloGoogleSearchGoogleChrome item.
            /// </summary>
            [RepositoryItem("f4a8d081-72a2-49d6-9f8c-c703303582bc")]
            public virtual Ranorex.TitleBar HelloGoogleSearchGoogleChrome
            {
                get
                {
                    return _hellogooglesearchgooglechromeInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The HelloGoogleSearchGoogleChrome item info.
            /// </summary>
            [RepositoryItemInfo("f4a8d081-72a2-49d6-9f8c-c703303582bc")]
            public virtual RepoItemInfo HelloGoogleSearchGoogleChromeInfo
            {
                get
                {
                    return _hellogooglesearchgooglechromeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}