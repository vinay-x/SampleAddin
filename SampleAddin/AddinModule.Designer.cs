namespace SampleAddin
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adxOlFormsManager1 = new AddinExpress.OL.ADXOlFormsManager(this.components);
            this.adxOlFormsCollectionItem1 = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            // 
            // adxOlFormsManager1
            // 
            this.adxOlFormsManager1.Items.Add(this.adxOlFormsCollectionItem1);
            this.adxOlFormsManager1.SetOwner(this);
            // 
            // adxOlFormsCollectionItem1
            // 
            this.adxOlFormsCollectionItem1.AlwaysShowHeader = true;
            this.adxOlFormsCollectionItem1.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.adxOlFormsCollectionItem1.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.adxOlFormsCollectionItem1.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.RightReadingPane;
            this.adxOlFormsCollectionItem1.FormClassName = "SampleAddin.ADXOlForm1";
            this.adxOlFormsCollectionItem1.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olMail;
            this.adxOlFormsCollectionItem1.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.RightSubpane;
            this.adxOlFormsCollectionItem1.IsHiddenStateAllowed = false;
            this.adxOlFormsCollectionItem1.RestoreFromMinimizedState = true;
            // 
            // AddinModule
            // 
            this.AddinName = "SampleAddin";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion

        private AddinExpress.OL.ADXOlFormsManager adxOlFormsManager1;
        public AddinExpress.OL.ADXOlFormsCollectionItem adxOlFormsCollectionItem1;
    }
}

