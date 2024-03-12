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

namespace Opc.Ua.ISO22400-2
{
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint KPIElements_Logistical_elements = 5006;

        /// <remarks />
        public const uint KPIElements_Quality_elements = 5007;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2 = 5008;

        /// <remarks />
        public const uint KPIElements_Time_elements = 5002;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times = 5004;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times = 5005;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times = 5003;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2_ = 5001;
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
        public const uint KPIElements = 1008;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint KeyPerformanceIndicator_Actual_to_planned_scrap_ratio = 6014;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_efficiency = 6004;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Allocation_ratio = 6002;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Availability = 6008;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Comprehensive_energy_consumption = 6023;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Corrective_maintenance_ratio = 6034;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_machine_capability_index = 6020;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Critical_process_capability_index = 6022;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Effectiveness = 6009;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Equipment_load_ratio = 6030;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Fall_off_ratio = 6018;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Finished_goods_ratio = 6025;

        /// <remarks />
        public const uint KeyPerformanceIndicator_First_pass_yield = 6015;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Integrated_goods_ratio = 6026;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Inventory_turns = 6024;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Machine_capability_index = 6019;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_operating_time_between_failures = 6031;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_failure = 6032;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Mean_time_to_repair = 6033;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Net_equipment_effectiveness_index = 6007;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Other_loss_ratio_KPI = 6029;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Overall_equipment_effectiveness_index = 6006;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Process_capability_index_KPI = 6021;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_loss_ratio = 6027;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Production_process_ratio = 6013;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Quality_ratio = 6010;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Rework_ratio = 6017;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Scrap_ratio = 6016;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Setup_ratio = 6011;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Storage_and_transportation_loss_ratio = 6028;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Technical_efficiency = 6012;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Throughput_rate = 6003;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Utilization_efficiency = 6005;

        /// <remarks />
        public const uint KeyPerformanceIndicator_Worker_efficiency = 6001;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Consumable_inventory = 6076;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Consumed_material = 6077;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Equipment_production_capacity = 6082;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Finished_goods_inventory = 6075;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Good_quantity = 6070;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Integrated_good_quantity = 6078;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Other_loss = 6081;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Planned_order_quantity = 6067;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Planned_scrap_quantity = 6069;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Produced_quantity = 6072;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Production_loss = 6079;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Raw_materials = 6073;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Raw_materials_inventory = 6074;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Rework_quantity = 6071;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Scrap_quantity = 6068;

        /// <remarks />
        public const uint KPIElements_Logistical_elements_Storage_and_transportation_loss = 6080;

        /// <remarks />
        public const uint KPIElements_Quality_elements_Good_part = 6083;

        /// <remarks />
        public const uint KPIElements_Quality_elements_Inspected_part = 6084;

        /// <remarks />
        public const uint KPIElements_Quality_elements_Lower_specification_limit = 6086;

        /// <remarks />
        public const uint KPIElements_Quality_elements_Upper_specification_limit = 6085;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2_Arithmetic_average = 6087;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2_Average_of_average_values = 6088;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2_Estimated_deviation = 6089;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2_Standard_deviation = 6090;

        /// <remarks />
        public const uint KPIElements_Quality_elements_2_Variance = 6091;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_order_execution_time = 6050;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_order_execution_time_2 = 6060;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_personnel_attendance_time = 6051;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_personnel_work_time = 6047;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_production_time = 6052;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_queuing_time = 6053;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_transport_time = 6057;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_busy_time = 6049;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_busy_time_2 = 6059;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_delay_time = 6055;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_down_time = 6054;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_processing_time = 6048;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_processing_time_2 = 6058;

        /// <remarks />
        public const uint KPIElements_Time_elements_Actual_times_Actual_unit_setup_time = 6056;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Corrective_maintenance_time = 6065;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Failure_event_count = 6064;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Preventive_maintenance_time = 6066;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Time_between_failures = 6061;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Time_to_failure = 6063;

        /// <remarks />
        public const uint KPIElements_Time_elements_Maintenance_times_Time_to_repair = 6062;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times_Planned_busy_time = 6045;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times_Planned_operation_time = 6043;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times_Planned_order_execution_time = 6042;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times_Planned_run_time_per_item = 6046;

        /// <remarks />
        public const uint KPIElements_Time_elements_Planned_times_Planned_unit_setup_time = 6044;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__NamespaceUri = 6037;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__NamespaceVersion = 6038;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__NamespacePublicationDate = 6036;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__IsNamespaceSubset = 6035;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__StaticNodeIdTypes = 6039;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__StaticNumericNodeIdRange = 6040;

        /// <remarks />
        public const uint http___yourorganisation_org_ISO22400_2__StaticStringNodeIdPattern = 6041;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Logistical_elements, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Quality_elements, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2 = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Quality_elements_2, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Time_elements, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Time_elements_Actual_times, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Time_elements_Maintenance_times, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.KPIElements_Time_elements_Planned_times, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2_ = new ExpandedNodeId(Opc.Ua.ISO22400-2.Objects.http___yourorganisation_org_ISO22400_2_, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator = new ExpandedNodeId(Opc.Ua.ISO22400-2.ObjectTypes.KeyPerformanceIndicator, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements = new ExpandedNodeId(Opc.Ua.ISO22400-2.ObjectTypes.KPIElements, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Actual_to_planned_scrap_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Actual_to_planned_scrap_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_efficiency = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Allocation_efficiency, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Allocation_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Allocation_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Availability = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Availability, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Comprehensive_energy_consumption = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Comprehensive_energy_consumption, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Corrective_maintenance_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Corrective_maintenance_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_machine_capability_index = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Critical_machine_capability_index, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Critical_process_capability_index = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Critical_process_capability_index, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Effectiveness = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Effectiveness, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Equipment_load_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Equipment_load_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Fall_off_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Fall_off_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Finished_goods_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Finished_goods_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_First_pass_yield = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_First_pass_yield, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Integrated_goods_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Integrated_goods_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Inventory_turns = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Inventory_turns, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Machine_capability_index = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Machine_capability_index, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_operating_time_between_failures = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Mean_operating_time_between_failures, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_failure = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_failure, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Mean_time_to_repair = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Mean_time_to_repair, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Net_equipment_effectiveness_index = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Net_equipment_effectiveness_index, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Other_loss_ratio_KPI = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Other_loss_ratio_KPI, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Overall_equipment_effectiveness_index = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Overall_equipment_effectiveness_index, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Process_capability_index_KPI = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Process_capability_index_KPI, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_loss_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Production_loss_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Production_process_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Production_process_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Quality_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Quality_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Rework_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Rework_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Scrap_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Scrap_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Setup_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Setup_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Storage_and_transportation_loss_ratio = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Storage_and_transportation_loss_ratio, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Technical_efficiency = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Technical_efficiency, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Throughput_rate = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Throughput_rate, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Utilization_efficiency = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Utilization_efficiency, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KeyPerformanceIndicator_Worker_efficiency = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KeyPerformanceIndicator_Worker_efficiency, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Consumable_inventory = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Consumable_inventory, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Consumed_material = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Consumed_material, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Equipment_production_capacity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Equipment_production_capacity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Finished_goods_inventory = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Finished_goods_inventory, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Good_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Good_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Integrated_good_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Integrated_good_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Other_loss = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Other_loss, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Planned_order_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Planned_order_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Planned_scrap_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Planned_scrap_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Produced_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Produced_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Production_loss = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Production_loss, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Raw_materials = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Raw_materials, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Raw_materials_inventory = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Raw_materials_inventory, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Rework_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Rework_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Scrap_quantity = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Scrap_quantity, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Logistical_elements_Storage_and_transportation_loss = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Logistical_elements_Storage_and_transportation_loss, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_Good_part = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_Good_part, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_Inspected_part = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_Inspected_part, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_Lower_specification_limit = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_Lower_specification_limit, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_Upper_specification_limit = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_Upper_specification_limit, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2_Arithmetic_average = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_2_Arithmetic_average, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2_Average_of_average_values = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_2_Average_of_average_values, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2_Estimated_deviation = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_2_Estimated_deviation, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2_Standard_deviation = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_2_Standard_deviation, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Quality_elements_2_Variance = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Quality_elements_2_Variance, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_order_execution_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_order_execution_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_order_execution_time_2 = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_order_execution_time_2, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_personnel_attendance_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_personnel_attendance_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_personnel_work_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_personnel_work_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_production_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_production_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_queuing_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_queuing_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_transport_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_transport_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_busy_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_busy_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_busy_time_2 = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_busy_time_2, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_delay_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_delay_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_down_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_down_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_processing_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_processing_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_processing_time_2 = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_processing_time_2, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Actual_times_Actual_unit_setup_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Actual_times_Actual_unit_setup_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Corrective_maintenance_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Corrective_maintenance_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Failure_event_count = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Failure_event_count, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Preventive_maintenance_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Preventive_maintenance_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Time_between_failures = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Time_between_failures, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Time_to_failure = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Time_to_failure, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Maintenance_times_Time_to_repair = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Maintenance_times_Time_to_repair, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times_Planned_busy_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Planned_times_Planned_busy_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times_Planned_operation_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Planned_times_Planned_operation_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times_Planned_order_execution_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Planned_times_Planned_order_execution_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times_Planned_run_time_per_item = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Planned_times_Planned_run_time_per_item, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId KPIElements_Time_elements_Planned_times_Planned_unit_setup_time = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.KPIElements_Time_elements_Planned_times_Planned_unit_setup_time, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__NamespaceUri = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__NamespaceUri, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__NamespaceVersion = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__NamespaceVersion, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__NamespacePublicationDate, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__IsNamespaceSubset, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__StaticNodeIdTypes, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__StaticNumericNodeIdRange, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_ISO22400_2__StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.ISO22400-2.Variables.http___yourorganisation_org_ISO22400_2__StaticStringNodeIdPattern, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Actual_to_planned_scrap_ratio = "Actual to planned scrap ratio";

        /// <remarks />
        public const string Allocation_efficiency = "Allocation efficiency";

        /// <remarks />
        public const string Allocation_ratio = "Allocation ratio";

        /// <remarks />
        public const string Availability = "Availability";

        /// <remarks />
        public const string Comprehensive_energy_consumption = "Comprehensive energy consumption";

        /// <remarks />
        public const string Corrective_maintenance_ratio = "Corrective maintenance ratio";

        /// <remarks />
        public const string Critical_machine_capability_index = "Critical machine capability index";

        /// <remarks />
        public const string Critical_process_capability_index = "Critical process capability index";

        /// <remarks />
        public const string Effectiveness = "Effectiveness";

        /// <remarks />
        public const string Equipment_load_ratio = "Equipment load ratio";

        /// <remarks />
        public const string Fall_off_ratio = "Fall off ratio";

        /// <remarks />
        public const string Finished_goods_ratio = "Finished goods ratio";

        /// <remarks />
        public const string First_pass_yield = "First pass yield";

        /// <remarks />
        public const string http___yourorganisation_org_ISO22400_2_ = "http://yourorganisation.org/ISO22400-2/";

        /// <remarks />
        public const string Integrated_goods_ratio = "Integrated goods ratio";

        /// <remarks />
        public const string Inventory_turns = "Inventory turns";

        /// <remarks />
        public const string KeyPerformanceIndicator = "KeyPerformanceIndicator";

        /// <remarks />
        public const string KPIElements = "KPIElements";

        /// <remarks />
        public const string Logistical_elements = "Logistical_elements";

        /// <remarks />
        public const string Machine_capability_index = "Machine capability index";

        /// <remarks />
        public const string Mean_operating_time_between_failures = "Mean operating time between failures";

        /// <remarks />
        public const string Mean_time_to_failure = "Mean time to failure";

        /// <remarks />
        public const string Mean_time_to_repair = "Mean time to repair";

        /// <remarks />
        public const string Net_equipment_effectiveness_index = "Net equipment effectiveness index";

        /// <remarks />
        public const string Other_loss_ratio_KPI = "Other loss ratio
KPI";

        /// <remarks />
        public const string Overall_equipment_effectiveness_index = "Overall equipment effectiveness index";

        /// <remarks />
        public const string Process_capability_index_KPI = "Process capability index
KPI";

        /// <remarks />
        public const string Production_loss_ratio = "Production loss ratio";

        /// <remarks />
        public const string Production_process_ratio = "Production process ratio";

        /// <remarks />
        public const string Quality_elements = "Quality_elements";

        /// <remarks />
        public const string Quality_elements_2 = "Quality_elements_2";

        /// <remarks />
        public const string Quality_ratio = "Quality ratio";

        /// <remarks />
        public const string Rework_ratio = "Rework ratio";

        /// <remarks />
        public const string Scrap_ratio = "Scrap ratio";

        /// <remarks />
        public const string Setup_ratio = "Setup ratio";

        /// <remarks />
        public const string Storage_and_transportation_loss_ratio = "Storage and transportation loss ratio";

        /// <remarks />
        public const string Technical_efficiency = "Technical efficiency";

        /// <remarks />
        public const string Throughput_rate = "Throughput rate";

        /// <remarks />
        public const string Time_elements = "Time_elements";

        /// <remarks />
        public const string Utilization_efficiency = "Utilization efficiency";

        /// <remarks />
        public const string Worker_efficiency = "Worker efficiency";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ISO22400-2 namespace (.NET code namespace is 'Opc.Ua.ISO22400-2').
        /// </summary>
        public const string ISO22400-2 = "http://yourorganisation.org/ISO22400-2/";

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