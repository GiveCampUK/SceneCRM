

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Child : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Child entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Child()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Child(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Child> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Child.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Child_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Child_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ChildId
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.ChildId);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ChildId_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ChildId_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ChildId_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Reference
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Reference);
            }
            set
            {
                global::LightSwitchApplication.Child.DetailsClass.SetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Reference, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Reference_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Reference_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Reference_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string FirstName
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.FirstName);
            }
            set
            {
                global::LightSwitchApplication.Child.DetailsClass.SetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.FirstName, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Surname
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Surname);
            }
            set
            {
                global::LightSwitchApplication.Child.DetailsClass.SetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Surname, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.CourseAttendance> CourseAttendances
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetValue(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.CourseAttendances);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.CourseAttendance> CourseAttendancesQuery
        {
            get
            {
                return global::LightSwitchApplication.Child.DetailsClass.GetQuery(this, global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.CourseAttendances);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Child,
                global::LightSwitchApplication.Child.DetailsClass,
                global::LightSwitchApplication.Child.DetailsClass.IImplementation,
                global::LightSwitchApplication.Child.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.ChildId;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>.Entry
                __ChildEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>.Entry(
                    global::LightSwitchApplication.Child.DetailsClass.__Child_CreateNew,
                    global::LightSwitchApplication.Child.DetailsClass.__Child_Created,
                    global::LightSwitchApplication.Child.DetailsClass.__Child_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Child __Child_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Child> es)
            {
                return new global::LightSwitchApplication.Child(es);
            }
            private static void __Child_Created(global::LightSwitchApplication.Child e)
            {
                e.Child_Created();
            }
            private static bool __Child_AllowSaveWithErrors(global::LightSwitchApplication.Child e)
            {
                bool result = false;
                e.Child_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Child.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int> ChildId
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.ChildId) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string> Reference
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Reference) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string> FirstName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.FirstName) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string> Surname
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.Surname) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance> CourseAttendances
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.CourseAttendances) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int ChildId { get; }
                new string Reference { get; set; }
                new string FirstName { get; set; }
                new string Surname { get; set; }
                new global::System.Collections.IEnumerable CourseAttendances { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int>.Entry
                    ChildId = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int>.Entry(
                        "ChildId",
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._ChildId_Stub,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._ChildId_ComputeIsReadOnly,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._ChildId_Validate,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._ChildId_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._ChildId_OnValueChanged);
                private static void _ChildId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Child.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int>.Data> c, global::LightSwitchApplication.Child.DetailsClass d, object sf)
                {
                    c(d, ref d._ChildId, sf);
                }
                private static bool _ChildId_ComputeIsReadOnly(global::LightSwitchApplication.Child e)
                {
                    bool result = false;
                    e.ChildId_IsReadOnly(ref result);
                    return result;
                }
                private static void _ChildId_Validate(global::LightSwitchApplication.Child e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.ChildId_Validate(r);
                }
                private static int _ChildId_GetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.ImplementationEntity.ChildId;
                }
                private static void _ChildId_OnValueChanged(global::LightSwitchApplication.Child e)
                {
                    e.ChildId_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry
                    Reference = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry(
                        "Reference",
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_Stub,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_ComputeIsReadOnly,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_Validate,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_GetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_SetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Reference_OnValueChanged);
                private static void _Reference_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Child.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data> c, global::LightSwitchApplication.Child.DetailsClass d, object sf)
                {
                    c(d, ref d._Reference, sf);
                }
                private static bool _Reference_ComputeIsReadOnly(global::LightSwitchApplication.Child e)
                {
                    bool result = false;
                    e.Reference_IsReadOnly(ref result);
                    return result;
                }
                private static void _Reference_Validate(global::LightSwitchApplication.Child e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Reference_Validate(r);
                }
                private static string _Reference_GetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.ImplementationEntity.Reference;
                }
                private static void _Reference_SetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Reference = v;
                }
                private static void _Reference_OnValueChanged(global::LightSwitchApplication.Child e)
                {
                    e.Reference_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry
                    FirstName = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry(
                        "FirstName",
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_Stub,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_ComputeIsReadOnly,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_Validate,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_GetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_SetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._FirstName_OnValueChanged);
                private static void _FirstName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Child.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data> c, global::LightSwitchApplication.Child.DetailsClass d, object sf)
                {
                    c(d, ref d._FirstName, sf);
                }
                private static bool _FirstName_ComputeIsReadOnly(global::LightSwitchApplication.Child e)
                {
                    bool result = false;
                    e.FirstName_IsReadOnly(ref result);
                    return result;
                }
                private static void _FirstName_Validate(global::LightSwitchApplication.Child e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.FirstName_Validate(r);
                }
                private static string _FirstName_GetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.ImplementationEntity.FirstName;
                }
                private static void _FirstName_SetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d, string v)
                {
                    d.ImplementationEntity.FirstName = v;
                }
                private static void _FirstName_OnValueChanged(global::LightSwitchApplication.Child e)
                {
                    e.FirstName_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry
                    Surname = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Entry(
                        "Surname",
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_Stub,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_ComputeIsReadOnly,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_Validate,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_GetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_SetImplementationValue,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._Surname_OnValueChanged);
                private static void _Surname_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Child.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data> c, global::LightSwitchApplication.Child.DetailsClass d, object sf)
                {
                    c(d, ref d._Surname, sf);
                }
                private static bool _Surname_ComputeIsReadOnly(global::LightSwitchApplication.Child e)
                {
                    bool result = false;
                    e.Surname_IsReadOnly(ref result);
                    return result;
                }
                private static void _Surname_Validate(global::LightSwitchApplication.Child e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Surname_Validate(r);
                }
                private static string _Surname_GetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.ImplementationEntity.Surname;
                }
                private static void _Surname_SetImplementationValue(global::LightSwitchApplication.Child.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Surname = v;
                }
                private static void _Surname_OnValueChanged(global::LightSwitchApplication.Child e)
                {
                    e.Surname_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance>.Entry
                    CourseAttendances = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance>.Entry(
                        "CourseAttendances",
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._CourseAttendances_Stub,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._CourseAttendances_GetReferencedEntities,
                        global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties._CourseAttendances_GetEntityCollection);
                private static void _CourseAttendances_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Child.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance>.Data> c, global::LightSwitchApplication.Child.DetailsClass d, object sf)
                {
                    c(d, ref d._CourseAttendances, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.CourseAttendance> _CourseAttendances_GetReferencedEntities(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.CourseAttendance, global::LightSwitchApplication.CourseAttendance.DetailsClass>(global::LightSwitchApplication.Child.DetailsClass.PropertySetProperties.CourseAttendances, ref d._CourseAttendances);
                }
                private static global::System.Collections.IEnumerable _CourseAttendances_GetEntityCollection(global::LightSwitchApplication.Child.DetailsClass d)
                {
                    return d.ImplementationEntity.CourseAttendances;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, int>.Data _ChildId;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data _Reference;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data _FirstName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, string>.Data _Surname;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Child, global::LightSwitchApplication.Child.DetailsClass, global::LightSwitchApplication.CourseAttendance>.Data _CourseAttendances;
            
        }
    
        #endregion
    }
    
    #endregion
}
