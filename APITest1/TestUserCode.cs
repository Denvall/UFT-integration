namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Ext.BasicActivities;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.ActivityFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
	using HP.ST.Ext.CustomDataProviders.Extensions;
	using HP.ST.Ext.CustomDataProviders.ExcelFileArguments;
    
    [Serializable()]
    public class TestUserCode : TestEntities
    {
    	
    	/// <summary>
    	/// Handler for the Loop2 Activity¡¯s Condition event.
    	/// </summary>
    	/// <param name=\"sender\">The activity object that raised the Condition event.</param>
    	/// <param name=\"args\">The event arguments passed to the activity.</param>
    	/// Use this.Loop2 to access the Loop2 Activity's context, including input and output properties.
    	public bool Loop2_OnCondition(object sender, STActivityBaseEventArgs args)
    	{
    		//TODO: Add your code here...
    		return false;
    	}
}

}
