﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/18/2012
 * Time: 10:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Commands
{
    using System.Management.Automation;
    using Helpers;

    /// <summary>
    /// Description of ExportTmxTestSettingsCommand.
    /// </summary>
    [Cmdlet(VerbsData.Export, "TmxTestSettings")]
    public class ExportTmxTestSettingsCommand : SettingsCmdletBase
    {
        protected override void ProcessRecord()
        {
            // TmxHelper.ExportTestSettings(this, this.Path, this.VariableName);
            ImportExportHelper.ExportTestSettings(this, Path, VariableName);
        }
    }
}
