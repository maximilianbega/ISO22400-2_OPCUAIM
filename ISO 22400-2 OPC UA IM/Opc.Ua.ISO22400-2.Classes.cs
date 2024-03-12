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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.ISO22400-2
{
    #region KeyPerformanceIndicatorState Class
    #if (!OPCUA_EXCLUDE_KeyPerformanceIndicatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class KeyPerformanceIndicatorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public KeyPerformanceIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.ISO22400-2.ObjectTypes.KeyPerformanceIndicator, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvSVNPMjI0MDAtMi//////BGCAAgEAAAAB" +
           "AB8AAABLZXlQZXJmb3JtYW5jZUluZGljYXRvckluc3RhbmNlAQHsAwEB7APsAwAA/////yIAAAAVYMkK" +
           "AgAAAB0AAABBY3R1YWxfdG9fcGxhbm5lZF9zY3JhcF9yYXRpbwEAHQAAAEFjdHVhbCB0byBwbGFubmVk" +
           "IHNjcmFwIHJhdGlvAQF+FwAvAD9+FwAAAAv/////AwP/////AAAAABVgyQoCAAAAFQAAAEFsbG9jYXRp" +
           "b25fZWZmaWNpZW5jeQEAFQAAAEFsbG9jYXRpb24gZWZmaWNpZW5jeQEBdBcALwA/dBcAAAAL/////wMD" +
           "/////wAAAAAVYMkKAgAAABAAAABBbGxvY2F0aW9uX3JhdGlvAQAQAAAAQWxsb2NhdGlvbiByYXRpbwEB" +
           "chcALwA/chcAAAAL/////wMD/////wAAAAAVYIkKAgAAAAEADAAAAEF2YWlsYWJpbGl0eQEBeBcALwA/" +
           "eBcAAAAL/////wMD/////wAAAAAVYMkKAgAAACAAAABDb21wcmVoZW5zaXZlX2VuZXJneV9jb25zdW1w" +
           "dGlvbgEAIAAAAENvbXByZWhlbnNpdmUgZW5lcmd5IGNvbnN1bXB0aW9uAQGHFwAvAD+HFwAAAAv/////" +
           "AwP/////AAAAABVgyQoCAAAAHAAAAENvcnJlY3RpdmVfbWFpbnRlbmFuY2VfcmF0aW8BABwAAABDb3Jy" +
           "ZWN0aXZlIG1haW50ZW5hbmNlIHJhdGlvAQGSFwAvAD+SFwAAAAv/////AwP/////AAAAABVgyQoCAAAA" +
           "IQAAAENyaXRpY2FsX21hY2hpbmVfY2FwYWJpbGl0eV9pbmRleAEAIQAAAENyaXRpY2FsIG1hY2hpbmUg" +
           "Y2FwYWJpbGl0eSBpbmRleAEBhBcALwA/hBcAAAAL/////wMD/////wAAAAAVYMkKAgAAACEAAABDcml0" +
           "aWNhbF9wcm9jZXNzX2NhcGFiaWxpdHlfaW5kZXgBACEAAABDcml0aWNhbCBwcm9jZXNzIGNhcGFiaWxp" +
           "dHkgaW5kZXgBAYYXAC8AP4YXAAAAC/////8DA/////8AAAAAFWCJCgIAAAABAA0AAABFZmZlY3RpdmVu" +
           "ZXNzAQF5FwAvAD95FwAAAAv/////AwP/////AAAAABVgyQoCAAAAFAAAAEVxdWlwbWVudF9sb2FkX3Jh" +
           "dGlvAQAUAAAARXF1aXBtZW50IGxvYWQgcmF0aW8BAY4XAC8AP44XAAAAC/////8DA/////8AAAAAFWDJ" +
           "CgIAAAAOAAAARmFsbF9vZmZfcmF0aW8BAA4AAABGYWxsIG9mZiByYXRpbwEBghcALwA/ghcAAAAL////" +
           "/wMD/////wAAAAAVYMkKAgAAABQAAABGaW5pc2hlZF9nb29kc19yYXRpbwEAFAAAAEZpbmlzaGVkIGdv" +
           "b2RzIHJhdGlvAQGJFwAvAD+JFwAAAAv/////AwP/////AAAAABVgyQoCAAAAEAAAAEZpcnN0X3Bhc3Nf" +
           "eWllbGQBABAAAABGaXJzdCBwYXNzIHlpZWxkAQF/FwAvAD9/FwAAAAv/////AwP/////AAAAABVgyQoC" +
           "AAAAFgAAAEludGVncmF0ZWRfZ29vZHNfcmF0aW8BABYAAABJbnRlZ3JhdGVkIGdvb2RzIHJhdGlvAQGK" +
           "FwAvAD+KFwAAAAv/////AwP/////AAAAABVgyQoCAAAADwAAAEludmVudG9yeV90dXJucwEADwAAAElu" +
           "dmVudG9yeSB0dXJucwEBiBcALwA/iBcAAAAL/////wMD/////wAAAAAVYMkKAgAAABgAAABNYWNoaW5l" +
           "X2NhcGFiaWxpdHlfaW5kZXgBABgAAABNYWNoaW5lIGNhcGFiaWxpdHkgaW5kZXgBAYMXAC8AP4MXAAAA" +
           "C/////8DA/////8AAAAAFWDJCgIAAAAkAAAATWVhbl9vcGVyYXRpbmdfdGltZV9iZXR3ZWVuX2ZhaWx1" +
           "cmVzAQAkAAAATWVhbiBvcGVyYXRpbmcgdGltZSBiZXR3ZWVuIGZhaWx1cmVzAQGPFwAvAD+PFwAAAAv/" +
           "////AwP/////AAAAABVgyQoCAAAAFAAAAE1lYW5fdGltZV90b19mYWlsdXJlAQAUAAAATWVhbiB0aW1l" +
           "IHRvIGZhaWx1cmUBAZAXAC8AP5AXAAAAC/////8DA/////8AAAAAFWDJCgIAAAATAAAATWVhbl90aW1l" +
           "X3RvX3JlcGFpcgEAEwAAAE1lYW4gdGltZSB0byByZXBhaXIBAZEXAC8AP5EXAAAAC/////8DA/////8A" +
           "AAAAFWDJCgIAAAAhAAAATmV0X2VxdWlwbWVudF9lZmZlY3RpdmVuZXNzX2luZGV4AQAhAAAATmV0IGVx" +
           "dWlwbWVudCBlZmZlY3RpdmVuZXNzIGluZGV4AQF3FwAvAD93FwAAAAv/////AwP/////AAAAABVgyQoC" +
           "AAAAFAAAAE90aGVyX2xvc3NfcmF0aW9fS1BJAQAUAAAAT3RoZXIgbG9zcyByYXRpbwpLUEkBAY0XAC8A" +
           "P40XAAAAC/////8DA/////8AAAAAFWDJCgIAAAAlAAAAT3ZlcmFsbF9lcXVpcG1lbnRfZWZmZWN0aXZl" +
           "bmVzc19pbmRleAEAJQAAAE92ZXJhbGwgZXF1aXBtZW50IGVmZmVjdGl2ZW5lc3MgaW5kZXgBAXYXAC8A" +
           "P3YXAAAAC/////8DA/////8AAAAAFWDJCgIAAAAcAAAAUHJvY2Vzc19jYXBhYmlsaXR5X2luZGV4X0tQ" +
           "SQEAHAAAAFByb2Nlc3MgY2FwYWJpbGl0eSBpbmRleApLUEkBAYUXAC8AP4UXAAAAC/////8DA/////8A" +
           "AAAAFWDJCgIAAAAVAAAAUHJvZHVjdGlvbl9sb3NzX3JhdGlvAQAVAAAAUHJvZHVjdGlvbiBsb3NzIHJh" +
           "dGlvAQGLFwAvAD+LFwAAAAv/////AwP/////AAAAABVgyQoCAAAAGAAAAFByb2R1Y3Rpb25fcHJvY2Vz" +
           "c19yYXRpbwEAGAAAAFByb2R1Y3Rpb24gcHJvY2VzcyByYXRpbwEBfRcALwA/fRcAAAAL/////wMD////" +
           "/wAAAAAVYMkKAgAAAA0AAABRdWFsaXR5X3JhdGlvAQANAAAAUXVhbGl0eSByYXRpbwEBehcALwA/ehcA" +
           "AAAL/////wMD/////wAAAAAVYMkKAgAAAAwAAABSZXdvcmtfcmF0aW8BAAwAAABSZXdvcmsgcmF0aW8B" +
           "AYEXAC8AP4EXAAAAC/////8DA/////8AAAAAFWDJCgIAAAALAAAAU2NyYXBfcmF0aW8BAAsAAABTY3Jh" +
           "cCByYXRpbwEBgBcALwA/gBcAAAAL/////wMD/////wAAAAAVYMkKAgAAAAsAAABTZXR1cF9yYXRpbwEA" +
           "CwAAAFNldHVwIHJhdGlvAQF7FwAvAD97FwAAAAv/////AwP/////AAAAABVgyQoCAAAAJQAAAFN0b3Jh" +
           "Z2VfYW5kX3RyYW5zcG9ydGF0aW9uX2xvc3NfcmF0aW8BACUAAABTdG9yYWdlIGFuZCB0cmFuc3BvcnRh" +
           "dGlvbiBsb3NzIHJhdGlvAQGMFwAvAD+MFwAAAAv/////AwP/////AAAAABVgyQoCAAAAFAAAAFRlY2hu" +
           "aWNhbF9lZmZpY2llbmN5AQAUAAAAVGVjaG5pY2FsIGVmZmljaWVuY3kBAXwXAC8AP3wXAAAAC/////8D" +
           "A/////8AAAAAFWDJCgIAAAAPAAAAVGhyb3VnaHB1dF9yYXRlAQAPAAAAVGhyb3VnaHB1dCByYXRlAQFz" +
           "FwAvAD9zFwAAAAv/////AwP/////AAAAABVgyQoCAAAAFgAAAFV0aWxpemF0aW9uX2VmZmljaWVuY3kB" +
           "ABYAAABVdGlsaXphdGlvbiBlZmZpY2llbmN5AQF1FwAvAD91FwAAAAv/////AwP/////AAAAABVgyQoC" +
           "AAAAEQAAAFdvcmtlcl9lZmZpY2llbmN5AQARAAAAV29ya2VyIGVmZmljaWVuY3kBAXEXAC8AP3EXAAAA" +
           "C/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Actual_to_planned_scrap_ratio
        {
            get
            {
                return m_actual_to_planned_scrap_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actual_to_planned_scrap_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actual_to_planned_scrap_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Allocation_efficiency
        {
            get
            {
                return m_allocation_efficiency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_allocation_efficiency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_allocation_efficiency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Allocation_ratio
        {
            get
            {
                return m_allocation_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_allocation_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_allocation_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Availability
        {
            get
            {
                return m_availability;
            }

            set
            {
                if (!Object.ReferenceEquals(m_availability, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_availability = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Comprehensive_energy_consumption
        {
            get
            {
                return m_comprehensive_energy_consumption;
            }

            set
            {
                if (!Object.ReferenceEquals(m_comprehensive_energy_consumption, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_comprehensive_energy_consumption = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Corrective_maintenance_ratio
        {
            get
            {
                return m_corrective_maintenance_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_corrective_maintenance_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_corrective_maintenance_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Critical_machine_capability_index
        {
            get
            {
                return m_critical_machine_capability_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_critical_machine_capability_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_critical_machine_capability_index = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Critical_process_capability_index
        {
            get
            {
                return m_critical_process_capability_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_critical_process_capability_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_critical_process_capability_index = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Effectiveness
        {
            get
            {
                return m_effectiveness;
            }

            set
            {
                if (!Object.ReferenceEquals(m_effectiveness, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_effectiveness = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Equipment_load_ratio
        {
            get
            {
                return m_equipment_load_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_equipment_load_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_equipment_load_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Fall_off_ratio
        {
            get
            {
                return m_fall_off_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fall_off_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fall_off_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Finished_goods_ratio
        {
            get
            {
                return m_finished_goods_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_finished_goods_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_finished_goods_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> First_pass_yield
        {
            get
            {
                return m_first_pass_yield;
            }

            set
            {
                if (!Object.ReferenceEquals(m_first_pass_yield, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_first_pass_yield = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Integrated_goods_ratio
        {
            get
            {
                return m_integrated_goods_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_integrated_goods_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_integrated_goods_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Inventory_turns
        {
            get
            {
                return m_inventory_turns;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inventory_turns, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inventory_turns = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Machine_capability_index
        {
            get
            {
                return m_machine_capability_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machine_capability_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machine_capability_index = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Mean_operating_time_between_failures
        {
            get
            {
                return m_mean_operating_time_between_failures;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mean_operating_time_between_failures, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mean_operating_time_between_failures = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Mean_time_to_failure
        {
            get
            {
                return m_mean_time_to_failure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mean_time_to_failure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mean_time_to_failure = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Mean_time_to_repair
        {
            get
            {
                return m_mean_time_to_repair;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mean_time_to_repair, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mean_time_to_repair = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Net_equipment_effectiveness_index
        {
            get
            {
                return m_net_equipment_effectiveness_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_net_equipment_effectiveness_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_net_equipment_effectiveness_index = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Other_loss_ratio_KPI
        {
            get
            {
                return m_other_loss_ratio_KPI;
            }

            set
            {
                if (!Object.ReferenceEquals(m_other_loss_ratio_KPI, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_other_loss_ratio_KPI = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Overall_equipment_effectiveness_index
        {
            get
            {
                return m_overall_equipment_effectiveness_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_overall_equipment_effectiveness_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_overall_equipment_effectiveness_index = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Process_capability_index_KPI
        {
            get
            {
                return m_process_capability_index_KPI;
            }

            set
            {
                if (!Object.ReferenceEquals(m_process_capability_index_KPI, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_process_capability_index_KPI = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Production_loss_ratio
        {
            get
            {
                return m_production_loss_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_production_loss_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_production_loss_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Production_process_ratio
        {
            get
            {
                return m_production_process_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_production_process_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_production_process_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Quality_ratio
        {
            get
            {
                return m_quality_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quality_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quality_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Rework_ratio
        {
            get
            {
                return m_rework_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rework_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rework_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Scrap_ratio
        {
            get
            {
                return m_scrap_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_scrap_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_scrap_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Setup_ratio
        {
            get
            {
                return m_setup_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setup_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setup_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Storage_and_transportation_loss_ratio
        {
            get
            {
                return m_storage_and_transportation_loss_ratio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_storage_and_transportation_loss_ratio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_storage_and_transportation_loss_ratio = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Technical_efficiency
        {
            get
            {
                return m_technical_efficiency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_technical_efficiency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_technical_efficiency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Throughput_rate
        {
            get
            {
                return m_throughput_rate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_throughput_rate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_throughput_rate = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Utilization_efficiency
        {
            get
            {
                return m_utilization_efficiency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_utilization_efficiency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_utilization_efficiency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Worker_efficiency
        {
            get
            {
                return m_worker_efficiency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_worker_efficiency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_worker_efficiency = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_actual_to_planned_scrap_ratio != null)
            {
                children.Add(m_actual_to_planned_scrap_ratio);
            }

            if (m_allocation_efficiency != null)
            {
                children.Add(m_allocation_efficiency);
            }

            if (m_allocation_ratio != null)
            {
                children.Add(m_allocation_ratio);
            }

            if (m_availability != null)
            {
                children.Add(m_availability);
            }

            if (m_comprehensive_energy_consumption != null)
            {
                children.Add(m_comprehensive_energy_consumption);
            }

            if (m_corrective_maintenance_ratio != null)
            {
                children.Add(m_corrective_maintenance_ratio);
            }

            if (m_critical_machine_capability_index != null)
            {
                children.Add(m_critical_machine_capability_index);
            }

            if (m_critical_process_capability_index != null)
            {
                children.Add(m_critical_process_capability_index);
            }

            if (m_effectiveness != null)
            {
                children.Add(m_effectiveness);
            }

            if (m_equipment_load_ratio != null)
            {
                children.Add(m_equipment_load_ratio);
            }

            if (m_fall_off_ratio != null)
            {
                children.Add(m_fall_off_ratio);
            }

            if (m_finished_goods_ratio != null)
            {
                children.Add(m_finished_goods_ratio);
            }

            if (m_first_pass_yield != null)
            {
                children.Add(m_first_pass_yield);
            }

            if (m_integrated_goods_ratio != null)
            {
                children.Add(m_integrated_goods_ratio);
            }

            if (m_inventory_turns != null)
            {
                children.Add(m_inventory_turns);
            }

            if (m_machine_capability_index != null)
            {
                children.Add(m_machine_capability_index);
            }

            if (m_mean_operating_time_between_failures != null)
            {
                children.Add(m_mean_operating_time_between_failures);
            }

            if (m_mean_time_to_failure != null)
            {
                children.Add(m_mean_time_to_failure);
            }

            if (m_mean_time_to_repair != null)
            {
                children.Add(m_mean_time_to_repair);
            }

            if (m_net_equipment_effectiveness_index != null)
            {
                children.Add(m_net_equipment_effectiveness_index);
            }

            if (m_other_loss_ratio_KPI != null)
            {
                children.Add(m_other_loss_ratio_KPI);
            }

            if (m_overall_equipment_effectiveness_index != null)
            {
                children.Add(m_overall_equipment_effectiveness_index);
            }

            if (m_process_capability_index_KPI != null)
            {
                children.Add(m_process_capability_index_KPI);
            }

            if (m_production_loss_ratio != null)
            {
                children.Add(m_production_loss_ratio);
            }

            if (m_production_process_ratio != null)
            {
                children.Add(m_production_process_ratio);
            }

            if (m_quality_ratio != null)
            {
                children.Add(m_quality_ratio);
            }

            if (m_rework_ratio != null)
            {
                children.Add(m_rework_ratio);
            }

            if (m_scrap_ratio != null)
            {
                children.Add(m_scrap_ratio);
            }

            if (m_setup_ratio != null)
            {
                children.Add(m_setup_ratio);
            }

            if (m_storage_and_transportation_loss_ratio != null)
            {
                children.Add(m_storage_and_transportation_loss_ratio);
            }

            if (m_technical_efficiency != null)
            {
                children.Add(m_technical_efficiency);
            }

            if (m_throughput_rate != null)
            {
                children.Add(m_throughput_rate);
            }

            if (m_utilization_efficiency != null)
            {
                children.Add(m_utilization_efficiency);
            }

            if (m_worker_efficiency != null)
            {
                children.Add(m_worker_efficiency);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.ISO22400-2.BrowseNames.Actual_to_planned_scrap_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Actual_to_planned_scrap_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Actual_to_planned_scrap_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Actual_to_planned_scrap_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Actual_to_planned_scrap_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Allocation_efficiency:
                {
                    if (createOrReplace)
                    {
                        if (Allocation_efficiency == null)
                        {
                            if (replacement == null)
                            {
                                Allocation_efficiency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Allocation_efficiency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Allocation_efficiency;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Allocation_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Allocation_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Allocation_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Allocation_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Allocation_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Availability:
                {
                    if (createOrReplace)
                    {
                        if (Availability == null)
                        {
                            if (replacement == null)
                            {
                                Availability = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Availability = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Availability;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Comprehensive_energy_consumption:
                {
                    if (createOrReplace)
                    {
                        if (Comprehensive_energy_consumption == null)
                        {
                            if (replacement == null)
                            {
                                Comprehensive_energy_consumption = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Comprehensive_energy_consumption = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Comprehensive_energy_consumption;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Corrective_maintenance_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Corrective_maintenance_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Corrective_maintenance_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Corrective_maintenance_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Corrective_maintenance_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Critical_machine_capability_index:
                {
                    if (createOrReplace)
                    {
                        if (Critical_machine_capability_index == null)
                        {
                            if (replacement == null)
                            {
                                Critical_machine_capability_index = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Critical_machine_capability_index = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Critical_machine_capability_index;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Critical_process_capability_index:
                {
                    if (createOrReplace)
                    {
                        if (Critical_process_capability_index == null)
                        {
                            if (replacement == null)
                            {
                                Critical_process_capability_index = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Critical_process_capability_index = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Critical_process_capability_index;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Effectiveness:
                {
                    if (createOrReplace)
                    {
                        if (Effectiveness == null)
                        {
                            if (replacement == null)
                            {
                                Effectiveness = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Effectiveness = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Effectiveness;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Equipment_load_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Equipment_load_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Equipment_load_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Equipment_load_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Equipment_load_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Fall_off_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Fall_off_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Fall_off_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Fall_off_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Fall_off_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Finished_goods_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Finished_goods_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Finished_goods_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Finished_goods_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Finished_goods_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.First_pass_yield:
                {
                    if (createOrReplace)
                    {
                        if (First_pass_yield == null)
                        {
                            if (replacement == null)
                            {
                                First_pass_yield = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                First_pass_yield = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = First_pass_yield;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Integrated_goods_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Integrated_goods_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Integrated_goods_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Integrated_goods_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Integrated_goods_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Inventory_turns:
                {
                    if (createOrReplace)
                    {
                        if (Inventory_turns == null)
                        {
                            if (replacement == null)
                            {
                                Inventory_turns = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Inventory_turns = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Inventory_turns;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Machine_capability_index:
                {
                    if (createOrReplace)
                    {
                        if (Machine_capability_index == null)
                        {
                            if (replacement == null)
                            {
                                Machine_capability_index = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Machine_capability_index = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Machine_capability_index;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Mean_operating_time_between_failures:
                {
                    if (createOrReplace)
                    {
                        if (Mean_operating_time_between_failures == null)
                        {
                            if (replacement == null)
                            {
                                Mean_operating_time_between_failures = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Mean_operating_time_between_failures = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Mean_operating_time_between_failures;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Mean_time_to_failure:
                {
                    if (createOrReplace)
                    {
                        if (Mean_time_to_failure == null)
                        {
                            if (replacement == null)
                            {
                                Mean_time_to_failure = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Mean_time_to_failure = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Mean_time_to_failure;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Mean_time_to_repair:
                {
                    if (createOrReplace)
                    {
                        if (Mean_time_to_repair == null)
                        {
                            if (replacement == null)
                            {
                                Mean_time_to_repair = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Mean_time_to_repair = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Mean_time_to_repair;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Net_equipment_effectiveness_index:
                {
                    if (createOrReplace)
                    {
                        if (Net_equipment_effectiveness_index == null)
                        {
                            if (replacement == null)
                            {
                                Net_equipment_effectiveness_index = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Net_equipment_effectiveness_index = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Net_equipment_effectiveness_index;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Other_loss_ratio_KPI:
                {
                    if (createOrReplace)
                    {
                        if (Other_loss_ratio_KPI == null)
                        {
                            if (replacement == null)
                            {
                                Other_loss_ratio_KPI = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Other_loss_ratio_KPI = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Other_loss_ratio_KPI;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Overall_equipment_effectiveness_index:
                {
                    if (createOrReplace)
                    {
                        if (Overall_equipment_effectiveness_index == null)
                        {
                            if (replacement == null)
                            {
                                Overall_equipment_effectiveness_index = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Overall_equipment_effectiveness_index = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Overall_equipment_effectiveness_index;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Process_capability_index_KPI:
                {
                    if (createOrReplace)
                    {
                        if (Process_capability_index_KPI == null)
                        {
                            if (replacement == null)
                            {
                                Process_capability_index_KPI = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Process_capability_index_KPI = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Process_capability_index_KPI;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Production_loss_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Production_loss_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Production_loss_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Production_loss_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Production_loss_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Production_process_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Production_process_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Production_process_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Production_process_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Production_process_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Quality_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Quality_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Quality_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Quality_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Quality_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Rework_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Rework_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Rework_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Rework_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Rework_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Scrap_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Scrap_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Scrap_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Scrap_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Scrap_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Setup_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Setup_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Setup_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Setup_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Setup_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Storage_and_transportation_loss_ratio:
                {
                    if (createOrReplace)
                    {
                        if (Storage_and_transportation_loss_ratio == null)
                        {
                            if (replacement == null)
                            {
                                Storage_and_transportation_loss_ratio = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Storage_and_transportation_loss_ratio = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Storage_and_transportation_loss_ratio;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Technical_efficiency:
                {
                    if (createOrReplace)
                    {
                        if (Technical_efficiency == null)
                        {
                            if (replacement == null)
                            {
                                Technical_efficiency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Technical_efficiency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Technical_efficiency;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Throughput_rate:
                {
                    if (createOrReplace)
                    {
                        if (Throughput_rate == null)
                        {
                            if (replacement == null)
                            {
                                Throughput_rate = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Throughput_rate = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Throughput_rate;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Utilization_efficiency:
                {
                    if (createOrReplace)
                    {
                        if (Utilization_efficiency == null)
                        {
                            if (replacement == null)
                            {
                                Utilization_efficiency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Utilization_efficiency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Utilization_efficiency;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Worker_efficiency:
                {
                    if (createOrReplace)
                    {
                        if (Worker_efficiency == null)
                        {
                            if (replacement == null)
                            {
                                Worker_efficiency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Worker_efficiency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Worker_efficiency;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_actual_to_planned_scrap_ratio;
        private BaseDataVariableState<double> m_allocation_efficiency;
        private BaseDataVariableState<double> m_allocation_ratio;
        private BaseDataVariableState<double> m_availability;
        private BaseDataVariableState<double> m_comprehensive_energy_consumption;
        private BaseDataVariableState<double> m_corrective_maintenance_ratio;
        private BaseDataVariableState<double> m_critical_machine_capability_index;
        private BaseDataVariableState<double> m_critical_process_capability_index;
        private BaseDataVariableState<double> m_effectiveness;
        private BaseDataVariableState<double> m_equipment_load_ratio;
        private BaseDataVariableState<double> m_fall_off_ratio;
        private BaseDataVariableState<double> m_finished_goods_ratio;
        private BaseDataVariableState<double> m_first_pass_yield;
        private BaseDataVariableState<double> m_integrated_goods_ratio;
        private BaseDataVariableState<double> m_inventory_turns;
        private BaseDataVariableState<double> m_machine_capability_index;
        private BaseDataVariableState<double> m_mean_operating_time_between_failures;
        private BaseDataVariableState<double> m_mean_time_to_failure;
        private BaseDataVariableState<double> m_mean_time_to_repair;
        private BaseDataVariableState<double> m_net_equipment_effectiveness_index;
        private BaseDataVariableState<double> m_other_loss_ratio_KPI;
        private BaseDataVariableState<double> m_overall_equipment_effectiveness_index;
        private BaseDataVariableState<double> m_process_capability_index_KPI;
        private BaseDataVariableState<double> m_production_loss_ratio;
        private BaseDataVariableState<double> m_production_process_ratio;
        private BaseDataVariableState<double> m_quality_ratio;
        private BaseDataVariableState<double> m_rework_ratio;
        private BaseDataVariableState<double> m_scrap_ratio;
        private BaseDataVariableState<double> m_setup_ratio;
        private BaseDataVariableState<double> m_storage_and_transportation_loss_ratio;
        private BaseDataVariableState<double> m_technical_efficiency;
        private BaseDataVariableState<double> m_throughput_rate;
        private BaseDataVariableState<double> m_utilization_efficiency;
        private BaseDataVariableState<double> m_worker_efficiency;
        #endregion
    }
    #endif
    #endregion

    #region KPIElementsState Class
    #if (!OPCUA_EXCLUDE_KPIElementsState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class KPIElementsState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public KPIElementsState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.ISO22400-2.ObjectTypes.KPIElements, Opc.Ua.ISO22400-2.Namespaces.ISO22400-2, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvSVNPMjI0MDAtMi//////BGCAAgEAAAAB" +
           "ABMAAABLUElFbGVtZW50c0luc3RhbmNlAQHwAwEB8APwAwAA/////wQAAAAEYIAKAQAAAAEAEwAAAExv" +
           "Z2lzdGljYWxfZWxlbWVudHMBAY4TAC8AOo4TAAD/////EAAAABVgyQoCAAAAFAAAAENvbnN1bWFibGVf" +
           "aW52ZW50b3J5AQAUAAAAQ29uc3VtYWJsZSBpbnZlbnRvcnkBAbwXAC8AP7wXAAAAC/////8DA/////8A" +
           "AAAAFWDJCgIAAAARAAAAQ29uc3VtZWRfbWF0ZXJpYWwBABEAAABDb25zdW1lZCBtYXRlcmlhbAEBvRcA" +
           "LwA/vRcAAAAL/////wMD/////wAAAAAVYMkKAgAAAB0AAABFcXVpcG1lbnRfcHJvZHVjdGlvbl9jYXBh" +
           "Y2l0eQEAHQAAAEVxdWlwbWVudCBwcm9kdWN0aW9uIGNhcGFjaXR5AQHCFwAvAD/CFwAAAAv/////AwP/" +
           "////AAAAABVgyQoCAAAAGAAAAEZpbmlzaGVkX2dvb2RzX2ludmVudG9yeQEAGAAAAEZpbmlzaGVkIGdv" +
           "b2RzIGludmVudG9yeQEBuxcALwA/uxcAAAAL/////wMD/////wAAAAAVYMkKAgAAAA0AAABHb29kX3F1" +
           "YW50aXR5AQANAAAAR29vZCBxdWFudGl0eQEBthcALwA/thcAAAAL/////wMD/////wAAAAAVYMkKAgAA" +
           "ABgAAABJbnRlZ3JhdGVkX2dvb2RfcXVhbnRpdHkBABgAAABJbnRlZ3JhdGVkIGdvb2QgcXVhbnRpdHkB" +
           "Ab4XAC8AP74XAAAAC/////8DA/////8AAAAAFWDJCgIAAAAKAAAAT3RoZXJfbG9zcwEACgAAAE90aGVy" +
           "IGxvc3MBAcEXAC8AP8EXAAAAC/////8DA/////8AAAAAFWDJCgIAAAAWAAAAUGxhbm5lZF9vcmRlcl9x" +
           "dWFudGl0eQEAFgAAAFBsYW5uZWQgb3JkZXIgcXVhbnRpdHkBAbMXAC8AP7MXAAAAC/////8DA/////8A" +
           "AAAAFWDJCgIAAAAWAAAAUGxhbm5lZF9zY3JhcF9xdWFudGl0eQEAFgAAAFBsYW5uZWQgc2NyYXAgcXVh" +
           "bnRpdHkBAbUXAC8AP7UXAAAAC/////8DA/////8AAAAAFWDJCgIAAAARAAAAUHJvZHVjZWRfcXVhbnRp" +
           "dHkBABEAAABQcm9kdWNlZCBxdWFudGl0eQEBuBcALwA/uBcAAAAL/////wMD/////wAAAAAVYMkKAgAA" +
           "AA8AAABQcm9kdWN0aW9uX2xvc3MBAA8AAABQcm9kdWN0aW9uIGxvc3MBAb8XAC8AP78XAAAAC/////8D" +
           "A/////8AAAAAFWDJCgIAAAANAAAAUmF3X21hdGVyaWFscwEADQAAAFJhdyBtYXRlcmlhbHMBAbkXAC8A" +
           "P7kXAAAAC/////8DA/////8AAAAAFWDJCgIAAAAXAAAAUmF3X21hdGVyaWFsc19pbnZlbnRvcnkBABcA" +
           "AABSYXcgbWF0ZXJpYWxzIGludmVudG9yeQEBuhcALwA/uhcAAAAL/////wMD/////wAAAAAVYMkKAgAA" +
           "AA8AAABSZXdvcmtfcXVhbnRpdHkBAA8AAABSZXdvcmsgcXVhbnRpdHkBAbcXAC8AP7cXAAAAC/////8D" +
           "A/////8AAAAAFWDJCgIAAAAOAAAAU2NyYXBfcXVhbnRpdHkBAA4AAABTY3JhcCBxdWFudGl0eQEBtBcA" +
           "LwA/tBcAAAAL/////wMD/////wAAAAAVYMkKAgAAAB8AAABTdG9yYWdlX2FuZF90cmFuc3BvcnRhdGlv" +
           "bl9sb3NzAQAfAAAAU3RvcmFnZSBhbmQgdHJhbnNwb3J0YXRpb24gbG9zcwEBwBcALwA/wBcAAAAL////" +
           "/wMD/////wAAAAAEYIAKAQAAAAEAEAAAAFF1YWxpdHlfZWxlbWVudHMBAY8TAC8AOo8TAAD/////BAAA" +
           "ABVgyQoCAAAACQAAAEdvb2RfcGFydAEACQAAAEdvb2QgcGFydAEBwxcALwA/wxcAAAAL/////wMD////" +
           "/wAAAAAVYMkKAgAAAA4AAABJbnNwZWN0ZWRfcGFydAEADgAAAEluc3BlY3RlZCBwYXJ0AQHEFwAvAD/E" +
           "FwAAAAv/////AwP/////AAAAABVgyQoCAAAAGQAAAExvd2VyX3NwZWNpZmljYXRpb25fbGltaXQBABkA" +
           "AABMb3dlciBzcGVjaWZpY2F0aW9uIGxpbWl0AQHGFwAvAD/GFwAAAAv/////AwP/////AAAAABVgyQoC" +
           "AAAAGQAAAFVwcGVyX3NwZWNpZmljYXRpb25fbGltaXQBABkAAABVcHBlciBzcGVjaWZpY2F0aW9uIGxp" +
           "bWl0AQHFFwAvAD/FFwAAAAv/////AwP/////AAAAAARggAoBAAAAAQASAAAAUXVhbGl0eV9lbGVtZW50" +
           "c18yAQGQEwAvADqQEwAA/////wUAAAAVYMkKAgAAABIAAABBcml0aG1ldGljX2F2ZXJhZ2UBABIAAABB" +
           "cml0aG1ldGljIGF2ZXJhZ2UBAccXAC8AP8cXAAAAC/////8DA/////8AAAAAFWDJCgIAAAAZAAAAQXZl" +
           "cmFnZV9vZl9hdmVyYWdlX3ZhbHVlcwEAGQAAAEF2ZXJhZ2Ugb2YgYXZlcmFnZSB2YWx1ZXMBAcgXAC8A" +
           "P8gXAAAAC/////8DA/////8AAAAAFWDJCgIAAAATAAAARXN0aW1hdGVkX2RldmlhdGlvbgEAEwAAAEVz" +
           "dGltYXRlZCBkZXZpYXRpb24BAckXAC8AP8kXAAAAC/////8DA/////8AAAAAFWDJCgIAAAASAAAAU3Rh" +
           "bmRhcmRfZGV2aWF0aW9uAQASAAAAU3RhbmRhcmQgZGV2aWF0aW9uAQHKFwAvAD/KFwAAAAv/////AwP/" +
           "////AAAAABVgiQoCAAAAAQAIAAAAVmFyaWFuY2UBAcsXAC8AP8sXAAAAC/////8DA/////8AAAAABGCA" +
           "CgEAAAABAA0AAABUaW1lX2VsZW1lbnRzAQGKEwAvADqKEwAA/////wMAAAAEYIAKAQAAAAEADAAAAEFj" +
           "dHVhbF90aW1lcwEBjBMALwA6jBMAAP////8OAAAAFWDJCgIAAAAbAAAAQWN0dWFsX29yZGVyX2V4ZWN1" +
           "dGlvbl90aW1lAQAbAAAAQWN0dWFsIG9yZGVyIGV4ZWN1dGlvbiB0aW1lAQGiFwAvAD+iFwAAAAv/////" +
           "AwP/////AAAAABVgyQoCAAAAHQAAAEFjdHVhbF9vcmRlcl9leGVjdXRpb25fdGltZV8yAQAdAAAAQWN0" +
           "dWFsIG9yZGVyIGV4ZWN1dGlvbiB0aW1lXzIBAawXAC8AP6wXAAAAC/////8DA/////8AAAAAFWDJCgIA" +
           "AAAgAAAAQWN0dWFsX3BlcnNvbm5lbF9hdHRlbmRhbmNlX3RpbWUBACAAAABBY3R1YWwgcGVyc29ubmVs" +
           "IGF0dGVuZGFuY2UgdGltZQEBoxcALwA/oxcAAAAL/////wMD/////wAAAAAVYMkKAgAAABoAAABBY3R1" +
           "YWxfcGVyc29ubmVsX3dvcmtfdGltZQEAGgAAAEFjdHVhbCBwZXJzb25uZWwgd29yayB0aW1lAQGfFwAv" +
           "AD+fFwAAAAv/////AwP/////AAAAABVgyQoCAAAAFgAAAEFjdHVhbF9wcm9kdWN0aW9uX3RpbWUBABYA" +
           "AABBY3R1YWwgcHJvZHVjdGlvbiB0aW1lAQGkFwAvAD+kFwAAAAv/////AwP/////AAAAABVgyQoCAAAA" +
           "EwAAAEFjdHVhbF9xdWV1aW5nX3RpbWUBABMAAABBY3R1YWwgcXVldWluZyB0aW1lAQGlFwAvAD+lFwAA" +
           "AAv/////AwP/////AAAAABVgyQoCAAAAFQAAAEFjdHVhbF90cmFuc3BvcnRfdGltZQEAFQAAAEFjdHVh" +
           "bCB0cmFuc3BvcnQgdGltZQEBqRcALwA/qRcAAAAL/////wMD/////wAAAAAVYMkKAgAAABUAAABBY3R1" +
           "YWxfdW5pdF9idXN5X3RpbWUBABUAAABBY3R1YWwgdW5pdCBidXN5IHRpbWUBAaEXAC8AP6EXAAAAC///" +
           "//8DA/////8AAAAAFWDJCgIAAAAXAAAAQWN0dWFsX3VuaXRfYnVzeV90aW1lXzIBABcAAABBY3R1YWwg" +
           "dW5pdCBidXN5IHRpbWVfMgEBqxcALwA/qxcAAAAL/////wMD/////wAAAAAVYMkKAgAAABYAAABBY3R1" +
           "YWxfdW5pdF9kZWxheV90aW1lAQAWAAAAQWN0dWFsIHVuaXQgZGVsYXkgdGltZQEBpxcALwA/pxcAAAAL" +
           "/////wMD/////wAAAAAVYMkKAgAAABUAAABBY3R1YWxfdW5pdF9kb3duX3RpbWUBABUAAABBY3R1YWwg" +
           "dW5pdCBkb3duIHRpbWUBAaYXAC8AP6YXAAAAC/////8DA/////8AAAAAFWDJCgIAAAAbAAAAQWN0dWFs" +
           "X3VuaXRfcHJvY2Vzc2luZ190aW1lAQAbAAAAQWN0dWFsIHVuaXQgcHJvY2Vzc2luZyB0aW1lAQGgFwAv" +
           "AD+gFwAAAAv/////AwP/////AAAAABVgyQoCAAAAHQAAAEFjdHVhbF91bml0X3Byb2Nlc3NpbmdfdGlt" +
           "ZV8yAQAdAAAAQWN0dWFsIHVuaXQgcHJvY2Vzc2luZyB0aW1lXzIBAaoXAC8AP6oXAAAAC/////8DA///" +
           "//8AAAAAFWDJCgIAAAAWAAAAQWN0dWFsX3VuaXRfc2V0dXBfdGltZQEAFgAAAEFjdHVhbCB1bml0IHNl" +
           "dHVwIHRpbWUBAagXAC8AP6gXAAAAC/////8DA/////8AAAAABGCACgEAAAABABEAAABNYWludGVuYW5j" +
           "ZV90aW1lcwEBjRMALwA6jRMAAP////8GAAAAFWDJCgIAAAAbAAAAQ29ycmVjdGl2ZV9tYWludGVuYW5j" +
           "ZV90aW1lAQAbAAAAQ29ycmVjdGl2ZSBtYWludGVuYW5jZSB0aW1lAQGxFwAvAD+xFwAAAAv/////AwP/" +
           "////AAAAABVgyQoCAAAAEwAAAEZhaWx1cmVfZXZlbnRfY291bnQBABMAAABGYWlsdXJlIGV2ZW50IGNv" +
           "dW50AQGwFwAvAD+wFwAAAAv/////AwP/////AAAAABVgyQoCAAAAGwAAAFByZXZlbnRpdmVfbWFpbnRl" +
           "bmFuY2VfdGltZQEAGwAAAFByZXZlbnRpdmUgbWFpbnRlbmFuY2UgdGltZQEBshcALwA/shcAAAAL////" +
           "/wMD/////wAAAAAVYMkKAgAAABUAAABUaW1lX2JldHdlZW5fZmFpbHVyZXMBABUAAABUaW1lIGJldHdl" +
           "ZW4gZmFpbHVyZXMBAa0XAC8AP60XAAAAC/////8DA/////8AAAAAFWDJCgIAAAAPAAAAVGltZV90b19m" +
           "YWlsdXJlAQAPAAAAVGltZSB0byBmYWlsdXJlAQGvFwAvAD+vFwAAAAv/////AwP/////AAAAABVgyQoC" +
           "AAAADgAAAFRpbWVfdG9fcmVwYWlyAQAOAAAAVGltZSB0byByZXBhaXIBAa4XAC8AP64XAAAAC/////8D" +
           "A/////8AAAAABGCACgEAAAABAA0AAABQbGFubmVkX3RpbWVzAQGLEwAvADqLEwAA/////wUAAAAVYMkK" +
           "AgAAABEAAABQbGFubmVkX2J1c3lfdGltZQEAEQAAAFBsYW5uZWQgYnVzeSB0aW1lAQGdFwAvAD+dFwAA" +
           "AAv/////AwP/////AAAAABVgyQoCAAAAFgAAAFBsYW5uZWRfb3BlcmF0aW9uX3RpbWUBABYAAABQbGFu" +
           "bmVkIG9wZXJhdGlvbiB0aW1lAQGbFwAvAD+bFwAAAAv/////AwP/////AAAAABVgyQoCAAAAHAAAAFBs" +
           "YW5uZWRfb3JkZXJfZXhlY3V0aW9uX3RpbWUBABwAAABQbGFubmVkIG9yZGVyIGV4ZWN1dGlvbiB0aW1l" +
           "AQGaFwAvAD+aFwAAAAv/////AwP/////AAAAABVgyQoCAAAAGQAAAFBsYW5uZWRfcnVuX3RpbWVfcGVy" +
           "X2l0ZW0BABkAAABQbGFubmVkIHJ1biB0aW1lIHBlciBpdGVtAQGeFwAvAD+eFwAAAAv/////AwP/////" +
           "AAAAABVgyQoCAAAAFwAAAFBsYW5uZWRfdW5pdF9zZXR1cF90aW1lAQAXAAAAUGxhbm5lZCB1bml0IHNl" +
           "dHVwIHRpbWUBAZwXAC8AP5wXAAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState Logistical_elements
        {
            get
            {
                return m_logistical_elements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_logistical_elements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_logistical_elements = value;
            }
        }

        /// <remarks />
        public BaseObjectState Quality_elements
        {
            get
            {
                return m_quality_elements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quality_elements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quality_elements = value;
            }
        }

        /// <remarks />
        public BaseObjectState Quality_elements_2
        {
            get
            {
                return m_quality_elements_2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quality_elements_2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quality_elements_2 = value;
            }
        }

        /// <remarks />
        public BaseObjectState Time_elements
        {
            get
            {
                return m_time_elements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_time_elements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_time_elements = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_logistical_elements != null)
            {
                children.Add(m_logistical_elements);
            }

            if (m_quality_elements != null)
            {
                children.Add(m_quality_elements);
            }

            if (m_quality_elements_2 != null)
            {
                children.Add(m_quality_elements_2);
            }

            if (m_time_elements != null)
            {
                children.Add(m_time_elements);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.ISO22400-2.BrowseNames.Logistical_elements:
                {
                    if (createOrReplace)
                    {
                        if (Logistical_elements == null)
                        {
                            if (replacement == null)
                            {
                                Logistical_elements = new BaseObjectState(this);
                            }
                            else
                            {
                                Logistical_elements = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Logistical_elements;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Quality_elements:
                {
                    if (createOrReplace)
                    {
                        if (Quality_elements == null)
                        {
                            if (replacement == null)
                            {
                                Quality_elements = new BaseObjectState(this);
                            }
                            else
                            {
                                Quality_elements = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Quality_elements;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Quality_elements_2:
                {
                    if (createOrReplace)
                    {
                        if (Quality_elements_2 == null)
                        {
                            if (replacement == null)
                            {
                                Quality_elements_2 = new BaseObjectState(this);
                            }
                            else
                            {
                                Quality_elements_2 = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Quality_elements_2;
                    break;
                }

                case Opc.Ua.ISO22400-2.BrowseNames.Time_elements:
                {
                    if (createOrReplace)
                    {
                        if (Time_elements == null)
                        {
                            if (replacement == null)
                            {
                                Time_elements = new BaseObjectState(this);
                            }
                            else
                            {
                                Time_elements = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Time_elements;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_logistical_elements;
        private BaseObjectState m_quality_elements;
        private BaseObjectState m_quality_elements_2;
        private BaseObjectState m_time_elements;
        #endregion
    }
    #endif
    #endregion
}