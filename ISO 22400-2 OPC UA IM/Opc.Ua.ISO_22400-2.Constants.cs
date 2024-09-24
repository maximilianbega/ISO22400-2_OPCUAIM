/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.ISO_22400-2
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M = 7014;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M = 7004;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M = 7002;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_M = 7008;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M = 7023;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M = 7034;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M = 7020;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M = 7022;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_M = 7009;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M = 7030;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M = 7018;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M = 7025;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M = 7015;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M = 7026;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M = 7024;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M = 7019;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M = 7031;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M = 7032;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M = 7033;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M = 7007;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M = 7029;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M = 7006;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M = 7021;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M = 7027;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M = 7013;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M = 7010;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M = 7017;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M = 7016;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M = 7011;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M = 7028;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M = 7012;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M = 7003;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M = 7005;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M = 7001;

        /// <remarks />
        public const string KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Availability_Availability_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Effectiveness_Effectiveness_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_First_pass_yield_First_pass_yield_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Inventory_turns_Inventory_turns_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Process_capability_index_Process_capability_index_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Quality_ratio_Quality_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Rework_ratio_Rework_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Setup__ratio_Setup_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Throughput_rate_Throughput_rate_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_MMethodType = "";

        /// <remarks />
        public const string KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_MMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio = 5018;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency = 5009;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio = 5004;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability = 5008;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption = 5027;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio = 5038;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index = 5024;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index = 5026;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness = 5013;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio = 5034;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio = 5022;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio = 5029;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield = 5019;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio = 5030;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns = 5028;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index = 5023;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures = 5035;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure = 5036;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair = 5037;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index = 5012;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio = 5033;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index = 5011;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index = 5025;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio = 5031;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio = 5017;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio = 5014;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio = 5021;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio = 5020;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio = 5015;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio = 5032;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency = 5016;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate = 5005;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency = 5010;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency = 5001;

        /// <remarks />
        public const uint KPIElement_Logistical_elements = 5006;

        /// <remarks />
        public const uint KPIElement_Quality_elements = 5007;

        /// <remarks />
        public const uint KPIElement_Time_elements = 5002;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times = 5040;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times = 5041;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times = 5039;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2_ = 5003;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint KeyPerformanceIndicator = 1004;

        /// <remarks />
        public const uint KPIElement = 1005;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint Good_quantity = 6007;

        /// <remarks />
        public const uint Good_quantity_EURange = 6008;

        /// <remarks />
        public const uint Good_quantity_6009 = 6009;

        /// <remarks />
        public const uint Good_quantity_6009_EURange = 6010;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_InputArguments = 6163;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_OutputArguments = 6164;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V = 6162;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_Definition = 6166;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EURange = 6167;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EngineeringUnits = 6165;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_InputArguments = 6106;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_OutputArguments = 6107;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V = 6102;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_Definition = 6104;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EURange = 6105;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EngineeringUnits = 6103;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_InputArguments = 6029;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_OutputArguments = 6030;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V = 6021;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_Definition = 6025;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EURange = 6026;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EngineeringUnits = 6022;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_M_InputArguments = 6130;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_M_OutputArguments = 6131;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_V = 6126;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_V_Definition = 6128;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_V_EURange = 6129;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability_Availability_V_EngineeringUnits = 6127;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_InputArguments = 6216;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_OutputArguments = 6217;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V = 6218;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_Definition = 6220;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EURange = 6221;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EngineeringUnits = 6219;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_InputArguments = 6284;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_OutputArguments = 6285;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V = 6282;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_Definition = 6286;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EURange = 6287;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EngineeringUnits = 6283;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_InputArguments = 6201;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_OutputArguments = 6200;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V = 6198;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_Definition = 6202;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EURange = 6203;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EngineeringUnits = 6199;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_InputArguments = 6213;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_OutputArguments = 6212;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V = 6210;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_Definition = 6214;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EURange = 6215;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EngineeringUnits = 6211;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_M_InputArguments = 6134;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_M_OutputArguments = 6135;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_V = 6132;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_V_Definition = 6136;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EURange = 6137;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EngineeringUnits = 6133;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_InputArguments = 6260;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_OutputArguments = 6261;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V = 6258;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_Definition = 6262;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EURange = 6263;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EngineeringUnits = 6259;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_InputArguments = 6188;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_OutputArguments = 6189;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V = 6186;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_Definition = 6190;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EURange = 6191;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EngineeringUnits = 6187;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_InputArguments = 6230;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_OutputArguments = 6231;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V = 6228;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_Definition = 6232;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EURange = 6233;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EngineeringUnits = 6229;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_InputArguments = 6170;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_OutputArguments = 6171;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V = 6168;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_Definition = 6172;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EURange = 6173;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EngineeringUnits = 6169;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V = 6234;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_Definition = 6238;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EURange = 6239;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EngineeringUnits = 6235;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_InputArguments = 6236;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_OutputArguments = 6237;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_InputArguments = 6224;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_OutputArguments = 6225;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V = 6222;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_Definition = 6226;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EURange = 6227;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EngineeringUnits = 6223;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_InputArguments = 6194;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_OutputArguments = 6195;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V = 6192;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_Definition = 6196;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EURange = 6197;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EngineeringUnits = 6193;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_InputArguments = 6266;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_OutputArguments = 6267;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V = 6264;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_Definition = 6268;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EURange = 6269;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EngineeringUnits = 6265;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_InputArguments = 6272;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_OutputArguments = 6273;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V = 6270;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_Definition = 6274;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EURange = 6275;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EngineeringUnits = 6271;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_InputArguments = 6278;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_OutputArguments = 6279;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V = 6276;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_Definition = 6280;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EURange = 6281;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EngineeringUnits = 6277;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_InputArguments = 6122;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_OutputArguments = 6123;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V = 6120;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_Definition = 6124;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EURange = 6125;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EngineeringUnits = 6121;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_InputArguments = 6254;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_OutputArguments = 6255;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V = 6252;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_Definition = 6256;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EURange = 6257;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EngineeringUnits = 6253;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_InputArguments = 6116;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_OutputArguments = 6117;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2 = 6114;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_Definition = 6118;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EURange = 6119;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EngineeringUnits = 6115;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_InputArguments = 6206;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_OutputArguments = 6207;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V = 6204;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_Definition = 6208;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EURange = 6209;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EngineeringUnits = 6205;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_InputArguments = 6242;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_OutputArguments = 6243;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V = 6240;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_Definition = 6244;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EURange = 6245;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EngineeringUnits = 6241;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_InputArguments = 6158;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_OutputArguments = 6159;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V = 6156;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_Definition = 6160;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EURange = 6161;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EngineeringUnits = 6157;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_InputArguments = 6140;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_OutputArguments = 6141;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V = 6138;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_Definition = 6142;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EURange = 6143;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EngineeringUnits = 6139;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_InputArguments = 6182;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_OutputArguments = 6183;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V = 6180;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_Definition = 6184;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EURange = 6185;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EngineeringUnits = 6181;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_InputArguments = 6176;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_OutputArguments = 6177;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V = 6174;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_Definition = 6178;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EURange = 6179;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EngineeringUnits = 6175;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_InputArguments = 6145;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_OutputArguments = 6146;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V = 6144;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_Definition = 6148;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EURange = 6149;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EngineeringUnits = 6147;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_InputArguments = 6248;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_OutputArguments = 6249;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V = 6246;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_Definition = 6250;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EURange = 6251;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EngineeringUnits = 6247;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_InputArguments = 6152;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_OutputArguments = 6153;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V = 6150;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_Definition = 6154;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EURange = 6155;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EngineeringUnits = 6151;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_InputArguments = 6031;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_OutputArguments = 6032;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V = 6023;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_Definition = 6027;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EURange = 6028;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EngineeringUnits = 6024;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_InputArguments = 6112;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_OutputArguments = 6113;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V = 6108;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_Definition = 6110;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EURange = 6111;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EngineeringUnits = 6109;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_InputArguments = 6005;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_OutputArguments = 6006;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V = 6001;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_Definition = 6003;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EURange = 6004;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EngineeringUnits = 6002;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumable_inventory_CI = 6305;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumable_inventory_CI_Definition = 6326;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumable_inventory_CI_EngineeringUnits = 6306;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumed_material_CM = 6307;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumed_material_CM_Definition = 6327;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Consumed_material_CM_EngineeringUnits = 6308;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Equipment_production_capacity_EPC = 6317;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Equipment_production_capacity_EPC_Definition = 6332;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Equipment_production_capacity_EPC_EngineeringUnits = 6318;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Finished_goods_inventory_FGI = 6303;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Finished_goods_inventory_FGI_Definition = 6325;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Finished_goods_inventory_FGI_EngineeringUnits = 6304;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Good_quantity_GQ = 6293;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Good_quantity_GQ_Definition = 6320;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Good_quantity_GQ_EngineeringUnits = 6294;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Integrated_good_quantity_IGQ = 6309;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_Definition = 6328;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_EngineeringUnits = 6310;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Other_loss_OL = 6315;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Other_loss_OL_Definition = 6331;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Other_loss_OL_EngineeringUnits = 6316;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_order_quantity_POQ = 6033;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_order_quantity_POQ_Definition = 6035;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_order_quantity_POQ_EngineeringUnits = 6034;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ = 6291;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_Definition = 6319;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_EngineeringUnits = 6292;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Produced_quantity_PQ = 6297;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Produced_quantity_PQ_Definition = 6322;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Produced_quantity_PQ_EngineeringUnits = 6298;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Production_loss_PL = 6311;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Production_loss_PL_Definition = 6329;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Production_loss_PL_EngineeringUnits = 6312;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_inventory_RMI = 6301;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_inventory_RMI_Definition = 6324;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_inventory_RMI_EngineeringUnits = 6302;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_RM = 6299;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_RM_Definition = 6323;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Raw_materials_RM_EngineeringUnits = 6300;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Rework_quantity_RQ = 6295;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Rework_quantity_RQ_Definition = 6321;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Rework_quantity_RQ_EngineeringUnits = 6296;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Scrap_quantity_SQ = 6288;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Scrap_quantity_SQ_Definition = 6290;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Scrap_quantity_SQ_EngineeringUnits = 6289;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Storage_and_transportation_loss_STL = 6313;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_Definition = 6330;

        /// <remarks />
        public const uint KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_EngineeringUnits = 6314;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Arithmetic_average = 6339;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Arithmetic_average_Definition = 6352;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Arithmetic_average_EngineeringUnits = 6340;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Average_of_average_values = 6341;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Average_of_average_values_Definition = 6353;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Average_of_average_values_EngineeringUnits = 6342;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Estimated_deviation = 6343;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Estimated_deviation_Definition = 6354;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Estimated_deviation_EngineeringUnits = 6344;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Good_part = 6036;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Good_part_Definition = 6038;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Good_part_EngineeringUnits = 6037;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Inspected_part_IP = 6333;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Inspected_part_IP_Definition = 6349;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Inspected_part_IP_EngineeringUnits = 6334;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Lower_specification_limit_LSL = 6337;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Lower_specification_limit_LSL_Definition = 6351;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Lower_specification_limit_LSL_EngineeringUnits = 6338;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Standard_deviation = 6345;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Standard_deviation_Definition = 6355;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Standard_deviation_EngineeringUnits = 6346;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Upper_specification_limit_USL = 6335;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Upper_specification_limit_USL_Definition = 6350;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Upper_specification_limit_USL_EngineeringUnits = 6336;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Variance = 6347;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Variance_Definition = 6356;

        /// <remarks />
        public const uint KPIElement_Quality_elements_Variance_EngineeringUnits = 6348;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET = 6060;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_Definition = 6093;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_EngineeringUnits = 6061;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT = 6046;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_Definition = 6094;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_EngineeringUnits = 6047;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT = 6013;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_Definition = 6017;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_EngineeringUnits = 6014;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_production__time_APT = 6048;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_production__time_APT_Definition = 6096;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_production__time_APT_EngineeringUnits = 6049;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT = 6050;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_Definition = 6097;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_EngineeringUnits = 6051;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT = 6058;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_Definition = 6101;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_EngineeringUnits = 6059;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT = 6042;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_Definition = 6095;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_EngineeringUnits = 6043;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET = 6054;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_Definition = 6099;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_EngineeringUnits = 6055;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT = 6052;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_Definition = 6098;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_EngineeringUnits = 6053;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT = 6039;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_Definition = 6041;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_EngineeringUnits = 6040;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST = 6056;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_Definition = 6100;

        /// <remarks />
        public const uint KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_EngineeringUnits = 6057;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT = 6078;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_Definition = 6087;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_EngineeringUnits = 6079;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE = 6076;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_Definition = 6091;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_EngineeringUnits = 6077;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT = 6080;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_Definition = 6092;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_EngineeringUnits = 6081;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF = 6070;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_Definition = 6088;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_EngineeringUnits = 6071;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF = 6074;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_Definition = 6090;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_EngineeringUnits = 6075;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR = 6072;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_Definition = 6089;

        /// <remarks />
        public const uint KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_EngineeringUnits = 6073;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT = 6066;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_Definition = 6082;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_EngineeringUnits = 6067;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_operation_time_POT = 6062;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_Definition = 6083;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_EngineeringUnits = 6063;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET = 6044;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_Definition = 6084;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_EngineeringUnits = 6045;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI = 6068;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_Definition = 6085;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_EngineeringUnits = 6069;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST = 6064;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_Definition = 6086;

        /// <remarks />
        public const uint KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_EngineeringUnits = 6065;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__NamespaceUri = 6015;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__NamespaceVersion = 6016;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__NamespacePublicationDate = 6012;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__IsNamespaceSubset = 6011;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__StaticNodeIdTypes = 6018;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__StaticNumericNodeIdRange = 6019;

        /// <remarks />
        public const uint Chair_of_Production_Systems_ISO_22400_2__StaticStringNodeIdPattern = 6020;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Availability_Availability_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Effectiveness_Effectiveness_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Availability_Availability_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Effectiveness_Effectiveness_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_MMethodType = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Methods.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_MMethodType, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Allocation_efficiency, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Allocation_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Availability, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Comprehensive_energy_consumption, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Corrective_maintenance_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Critical_machine_capability_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Critical_process_capability_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Effectiveness, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Equipment_load_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Fall_off_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Finished_goods_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_First_pass_yield, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Integrated_goods_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Inventory_turns, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Machine_capability_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Mean_operating_time_between_failures, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Mean_time_to_failure, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Mean_time_to_repair, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Net_equipment_effectiveness_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Other_loss_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Overall_equipment_effectiveness_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Process_capability_index, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Production_loss_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Production_process_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Quality_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Rework_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Scrap_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Setup__ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Technical_efficiency, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Throughput_rate, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Utilization_efficiency, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KeyPerformanceIndicator_Worker_efficiency, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Logistical_elements, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Quality_elements, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Time_elements, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Time_elements_Actual_times, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Time_elements_Maintenance_times, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.KPIElement_Time_elements_Planned_times, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2_ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Objects.Chair_of_Production_Systems_ISO_22400_2_, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator = new ExpandedNodeId(Opc.Ua.ISO_22400-2.ObjectTypes.KeyPerformanceIndicator, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement = new ExpandedNodeId(Opc.Ua.ISO_22400-2.ObjectTypes.KPIElement, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Good_quantity = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Good_quantity, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Good_quantity_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Good_quantity_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Good_quantity_6009 = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Good_quantity_6009, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Good_quantity_6009_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Good_quantity_6009_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio_Actual_to_planned_scrap_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency_Allocation_efficiency_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio_Allocation_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability_Availability_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Availability_Availability_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption_Comprehensive_energy_consumption_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio_Corrective_maintenance_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index_Critical_machine_capability_index_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index_Critical_process_capability_index_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Effectiveness_Effectiveness_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio__M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio_Equipment_load_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio_Fall_off_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio_Finished_goods_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_First_pass_yield_First_pass_yield_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio_Integrated_goods_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Inventory_turns_Inventory_turns_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index_Machine_capability_index_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures_Mean_operating_time_between_failures_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure_Mean_time_to_failure_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair_Mean_time_to_repair_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index_Net_equipment_effectiveness_index_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_Other_loss_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2 = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index_Overall_equipment_effectiveness_index_KPI_M_2_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_Process_capability_index_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio_Production_loss_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio_Production_process_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Quality_ratio_Quality_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Rework_ratio_Rework_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio_Scrap_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Setup__ratio_Setup_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio_Storage_and_transportation_loss_ratio_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency_Technical_efficiency_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Throughput_rate_Throughput_rate_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency_Utilization_efficiency_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_InputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_InputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_OutputArguments = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_M_OutputArguments, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EURange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EURange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency_Worker_efficiency_V_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumable_inventory_CI = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumable_inventory_CI, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumable_inventory_CI_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumable_inventory_CI_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumable_inventory_CI_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumable_inventory_CI_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumed_material_CM = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumed_material_CM, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumed_material_CM_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumed_material_CM_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Consumed_material_CM_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Consumed_material_CM_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Equipment_production_capacity_EPC = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Equipment_production_capacity_EPC, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Equipment_production_capacity_EPC_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Equipment_production_capacity_EPC_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Equipment_production_capacity_EPC_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Equipment_production_capacity_EPC_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Finished_goods_inventory_FGI = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Finished_goods_inventory_FGI, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Finished_goods_inventory_FGI_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Finished_goods_inventory_FGI_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Finished_goods_inventory_FGI_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Finished_goods_inventory_FGI_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Good_quantity_GQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Good_quantity_GQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Good_quantity_GQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Good_quantity_GQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Good_quantity_GQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Good_quantity_GQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Integrated_good_quantity_IGQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Integrated_good_quantity_IGQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Integrated_good_quantity_IGQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Other_loss_OL = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Other_loss_OL, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Other_loss_OL_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Other_loss_OL_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Other_loss_OL_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Other_loss_OL_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_order_quantity_POQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_order_quantity_POQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_order_quantity_POQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_order_quantity_POQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_order_quantity_POQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_order_quantity_POQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Planned_scrap_quantity__PSQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Produced_quantity_PQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Produced_quantity_PQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Produced_quantity_PQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Produced_quantity_PQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Produced_quantity_PQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Produced_quantity_PQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Production_loss_PL = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Production_loss_PL, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Production_loss_PL_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Production_loss_PL_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Production_loss_PL_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Production_loss_PL_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_inventory_RMI = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_inventory_RMI, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_inventory_RMI_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_inventory_RMI_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_inventory_RMI_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_inventory_RMI_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_RM = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_RM, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_RM_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_RM_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Raw_materials_RM_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Raw_materials_RM_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Rework_quantity_RQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Rework_quantity_RQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Rework_quantity_RQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Rework_quantity_RQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Rework_quantity_RQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Rework_quantity_RQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Scrap_quantity_SQ = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Scrap_quantity_SQ, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Scrap_quantity_SQ_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Scrap_quantity_SQ_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Scrap_quantity_SQ_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Scrap_quantity_SQ_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Storage_and_transportation_loss_STL = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Storage_and_transportation_loss_STL, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Logistical_elements_Storage_and_transportation_loss_STL_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Arithmetic_average = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Arithmetic_average, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Arithmetic_average_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Arithmetic_average_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Arithmetic_average_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Arithmetic_average_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Average_of_average_values = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Average_of_average_values, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Average_of_average_values_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Average_of_average_values_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Average_of_average_values_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Average_of_average_values_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Estimated_deviation = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Estimated_deviation, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Estimated_deviation_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Estimated_deviation_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Estimated_deviation_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Estimated_deviation_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Good_part = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Good_part, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Good_part_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Good_part_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Good_part_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Good_part_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Inspected_part_IP = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Inspected_part_IP, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Inspected_part_IP_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Inspected_part_IP_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Inspected_part_IP_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Inspected_part_IP_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Lower_specification_limit_LSL = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Lower_specification_limit_LSL, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Lower_specification_limit_LSL_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Lower_specification_limit_LSL_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Lower_specification_limit_LSL_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Lower_specification_limit_LSL_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Standard_deviation = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Standard_deviation, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Standard_deviation_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Standard_deviation_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Standard_deviation_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Standard_deviation_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Upper_specification_limit_USL = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Upper_specification_limit_USL, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Upper_specification_limit_USL_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Upper_specification_limit_USL_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Upper_specification_limit_USL_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Upper_specification_limit_USL_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Variance = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Variance, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Variance_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Variance_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Quality_elements_Variance_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Quality_elements_Variance_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_order_execution_time_AOET_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_attendance_time_APAT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_personnel_work_time_APWT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_production__time_APT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_production__time_APT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_production__time_APT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_production__time_APT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_production__time_APT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_production__time_APT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_queuing_time_AQT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_transport_time_ATT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_busy_time_AUBT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_delay_time_ADET_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_down_time_ADOT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_processing_time_AUPT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Actual_times_Actual_unit_setup_time_AUST_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Corrective_maintenance_time_CMT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Failure_event_count_FE_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Preventive_maintenance_time_PMT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_between_failures_TBF_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_failure_TTF_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Maintenance_times_Time_to_repair_TTR_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_busy_time_PBT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_operation_time_POT = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_operation_time_POT, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_operation_time_POT_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_order_execution_time_POET_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_run_time_per_item_PRI_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_Definition = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_Definition, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_EngineeringUnits = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.KPIElement_Time_elements_Planned_times_Planned_unit_setup_time_PUST_EngineeringUnits, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__NamespaceUri = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__NamespaceUri, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__NamespaceVersion = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__NamespaceVersion, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__NamespacePublicationDate, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__IsNamespaceSubset, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__StaticNodeIdTypes, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__StaticNumericNodeIdRange, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId Chair_of_Production_Systems_ISO_22400_2__StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.ISO_22400-2.Variables.Chair_of_Production_Systems_ISO_22400_2__StaticStringNodeIdPattern, Opc.Ua.ISO_22400-2.Namespaces.ISO_22400-2);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Actual_to_planned_scrap_ratio = "Actual_to_planned_scrap_ratio";

        /// <remarks />
        public const string Actual_to_planned_scrap_ratio_MMethodType = "Actual_to_planned_scrap_ratio_MMethodType";

        /// <remarks />
        public const string Allocation_efficiency = "Allocation_efficiency";

        /// <remarks />
        public const string Allocation_efficiency_MMethodType = "Allocation_efficiency_MMethodType";

        /// <remarks />
        public const string Allocation_ratio = "Allocation_ratio";

        /// <remarks />
        public const string Allocation_ratio_MMethodType = "Allocation_ratio_MMethodType";

        /// <remarks />
        public const string Availability = "Availability";

        /// <remarks />
        public const string Availability_MMethodType = "Availability_MMethodType";

        /// <remarks />
        public const string Chair_of_Production_Systems_ISO_22400_2_ = "Chair_of_Production_Systems/ISO_22400-2/";

        /// <remarks />
        public const string Comprehensive_energy_consumption = "Comprehensive_energy_consumption";

        /// <remarks />
        public const string Comprehensive_energy_consumption_MMethodType = "Comprehensive_energy_consumption_MMethodType";

        /// <remarks />
        public const string Corrective_maintenance_ratio = "Corrective_maintenance_ratio";

        /// <remarks />
        public const string Corrective_maintenance_ratio_MMethodType = "Corrective_maintenance_ratio_MMethodType";

        /// <remarks />
        public const string Critical_machine_capability_index = "Critical_machine_capability_index";

        /// <remarks />
        public const string Critical_machine_capability_index_MMethodType = "Critical_machine_capability_index_MMethodType";

        /// <remarks />
        public const string Critical_process_capability_index = "Critical_process_capability_index";

        /// <remarks />
        public const string Critical_process_capability_index_MMethodType = "Critical_process_capability_index_MMethodType";

        /// <remarks />
        public const string Effectiveness = "Effectiveness";

        /// <remarks />
        public const string Effectiveness_MMethodType = "Effectiveness_MMethodType";

        /// <remarks />
        public const string Equipment_load_ratio = "Equipment_load_ratio";

        /// <remarks />
        public const string Equipment_load_ratio__MMethodType = "Equipment_load_ratio__MMethodType";

        /// <remarks />
        public const string Fall_off_ratio = "Fall_off_ratio";

        /// <remarks />
        public const string Fall_off_ratio_MMethodType = "Fall_off_ratio_MMethodType";

        /// <remarks />
        public const string Finished_goods_ratio = "Finished_goods_ratio";

        /// <remarks />
        public const string Finished_goods_ratio_MMethodType = "Finished_goods_ratio_MMethodType";

        /// <remarks />
        public const string First_pass_yield = "First_pass_yield";

        /// <remarks />
        public const string First_pass_yield_MMethodType = "First_pass_yield_MMethodType";

        /// <remarks />
        public const string Good_quantity = "Good quantity";

        /// <remarks />
        public const string Integrated_goods_ratio = "Integrated-goods_ratio";

        /// <remarks />
        public const string Integrated_goods_ratio_MMethodType = "Integrated_goods_ratio_MMethodType";

        /// <remarks />
        public const string Inventory_turns = "Inventory_turns";

        /// <remarks />
        public const string Inventory_turns_MMethodType = "Inventory_turns_MMethodType";

        /// <remarks />
        public const string KeyPerformanceIndicator = "KeyPerformanceIndicator";

        /// <remarks />
        public const string KPIElement = "KPIElement";

        /// <remarks />
        public const string Logistical_elements = "Logistical_elements";

        /// <remarks />
        public const string Machine_capability_index = "Machine_capability_index";

        /// <remarks />
        public const string Machine_capability_index_MMethodType = "Machine_capability_index_MMethodType";

        /// <remarks />
        public const string Mean_operating_time_between_failures = "Mean_operating_time_between_failures";

        /// <remarks />
        public const string Mean_operating_time_between_failures_MMethodType = "Mean_operating_time_between_failures_MMethodType";

        /// <remarks />
        public const string Mean_time_to_failure = "Mean_time_to_failure";

        /// <remarks />
        public const string Mean_time_to_failure_MMethodType = "Mean_time_to_failure_MMethodType";

        /// <remarks />
        public const string Mean_time_to_repair = "Mean_time_to_repair";

        /// <remarks />
        public const string Mean_time_to_repair_MMethodType = "Mean_time_to_repair_MMethodType";

        /// <remarks />
        public const string Net_equipment_effectiveness_index = "Net_equipment_effectiveness_index";

        /// <remarks />
        public const string Net_equipment_effectiveness_index_MMethodType = "Net_equipment_effectiveness_index_MMethodType";

        /// <remarks />
        public const string Other_loss_ratio = "Other_loss_ratio";

        /// <remarks />
        public const string Other_loss_ratio_MMethodType = "Other_loss_ratio_MMethodType";

        /// <remarks />
        public const string Overall_equipment_effectiveness_index = "Overall_equipment_effectiveness_index";

        /// <remarks />
        public const string Overall_equipment_effectiveness_index_KPI_MMethodType = "Overall_equipment_effectiveness_index_KPI_MMethodType";

        /// <remarks />
        public const string Process_capability_index = "Process_capability_index";

        /// <remarks />
        public const string Process_capability_index_MMethodType = "Process_capability_index_MMethodType";

        /// <remarks />
        public const string Production_loss_ratio = "Production_loss_ratio";

        /// <remarks />
        public const string Production_loss_ratio_MMethodType = "Production_loss_ratio_MMethodType";

        /// <remarks />
        public const string Production_process_ratio = "Production_process_ratio";

        /// <remarks />
        public const string Production_process_ratio_MMethodType = "Production_process_ratio_MMethodType";

        /// <remarks />
        public const string Quality_elements = "Quality_elements";

        /// <remarks />
        public const string Quality_ratio = "Quality_ratio";

        /// <remarks />
        public const string Quality_ratio_MMethodType = "Quality_ratio_MMethodType";

        /// <remarks />
        public const string Rework_ratio = "Rework_ratio";

        /// <remarks />
        public const string Rework_ratio_MMethodType = "Rework_ratio_MMethodType";

        /// <remarks />
        public const string Scrap_ratio = "Scrap_ratio";

        /// <remarks />
        public const string Scrap_ratio_MMethodType = "Scrap_ratio_MMethodType";

        /// <remarks />
        public const string Setup__ratio = "Setup_ratio";

        /// <remarks />
        public const string Setup_ratio_MMethodType = "Setup_ratio_MMethodType";

        /// <remarks />
        public const string Storage_and_transportation_loss_ratio = "Storage_and_transportation_loss_ratio";

        /// <remarks />
        public const string Storage_and_transportation_loss_ratio_MMethodType = "Storage_and_transportation_loss_ratio_MMethodType";

        /// <remarks />
        public const string Technical_efficiency = "Technical_efficiency";

        /// <remarks />
        public const string Technical_efficiency_MMethodType = "Technical_efficiency_MMethodType";

        /// <remarks />
        public const string Throughput_rate = "Throughput_rate";

        /// <remarks />
        public const string Throughput_rate_MMethodType = "Throughput_rate_MMethodType";

        /// <remarks />
        public const string Time_elements = "Time_elements";

        /// <remarks />
        public const string Utilization_efficiency = "Utilization_efficiency";

        /// <remarks />
        public const string Utilization_efficiency_MMethodType = "Utilization_efficiency_MMethodType";

        /// <remarks />
        public const string Worker_efficiency = "Worker_efficiency";

        /// <remarks />
        public const string Worker_efficiency_MMethodType = "Worker_efficiency_MMethodType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ISO_22400-2 namespace (.NET code namespace is 'Opc.Ua.ISO_22400-2').
        /// </summary>
        public const string ISO_22400-2 = "Chair_of_Production_Systems/ISO_22400-2/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}