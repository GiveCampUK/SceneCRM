

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
    public sealed partial class Play : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Play entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Play()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Play(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Play> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Play.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Play_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Play_AllowSaveWithErrors(ref bool result);
    
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
        public int PlayId
        {
            get
            {
                return global::LightSwitchApplication.Play.DetailsClass.GetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayId);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PlayId_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PlayId_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PlayId_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ChildId
        {
            get
            {
                return global::LightSwitchApplication.Play.DetailsClass.GetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.ChildId);
            }
            set
            {
                global::LightSwitchApplication.Play.DetailsClass.SetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.ChildId, value);
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
        public string Title
        {
            get
            {
                return global::LightSwitchApplication.Play.DetailsClass.GetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.Title);
            }
            set
            {
                global::LightSwitchApplication.Play.DetailsClass.SetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.Title, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.PlayVolunteer> PlayVolunteers
        {
            get
            {
                return global::LightSwitchApplication.Play.DetailsClass.GetValue(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayVolunteers);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.PlayVolunteer> PlayVolunteersQuery
        {
            get
            {
                return global::LightSwitchApplication.Play.DetailsClass.GetQuery(this, global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayVolunteers);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Play,
                global::LightSwitchApplication.Play.DetailsClass,
                global::LightSwitchApplication.Play.DetailsClass.IImplementation,
                global::LightSwitchApplication.Play.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayId;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>.Entry
                __PlayEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>.Entry(
                    global::LightSwitchApplication.Play.DetailsClass.__Play_CreateNew,
                    global::LightSwitchApplication.Play.DetailsClass.__Play_Created,
                    global::LightSwitchApplication.Play.DetailsClass.__Play_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Play __Play_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Play> es)
            {
                return new global::LightSwitchApplication.Play(es);
            }
            private static void __Play_Created(global::LightSwitchApplication.Play e)
            {
                e.Play_Created();
            }
            private static bool __Play_AllowSaveWithErrors(global::LightSwitchApplication.Play e)
            {
                bool result = false;
                e.Play_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Play.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int> PlayId
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayId) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int> ChildId
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.ChildId) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string> Title
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.Title) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer> PlayVolunteers
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayVolunteers) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int PlayId { get; }
                new int ChildId { get; set; }
                new string Title { get; set; }
                new global::System.Collections.IEnumerable PlayVolunteers { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Entry
                    PlayId = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Entry(
                        "PlayId",
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayId_Stub,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayId_ComputeIsReadOnly,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayId_Validate,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayId_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayId_OnValueChanged);
                private static void _PlayId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Play.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Data> c, global::LightSwitchApplication.Play.DetailsClass d, object sf)
                {
                    c(d, ref d._PlayId, sf);
                }
                private static bool _PlayId_ComputeIsReadOnly(global::LightSwitchApplication.Play e)
                {
                    bool result = false;
                    e.PlayId_IsReadOnly(ref result);
                    return result;
                }
                private static void _PlayId_Validate(global::LightSwitchApplication.Play e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.PlayId_Validate(r);
                }
                private static int _PlayId_GetImplementationValue(global::LightSwitchApplication.Play.DetailsClass d)
                {
                    return d.ImplementationEntity.PlayId;
                }
                private static void _PlayId_OnValueChanged(global::LightSwitchApplication.Play e)
                {
                    e.PlayId_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Entry
                    ChildId = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Entry(
                        "ChildId",
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_Stub,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_ComputeIsReadOnly,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_Validate,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_GetImplementationValue,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_SetImplementationValue,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._ChildId_OnValueChanged);
                private static void _ChildId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Play.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Data> c, global::LightSwitchApplication.Play.DetailsClass d, object sf)
                {
                    c(d, ref d._ChildId, sf);
                }
                private static bool _ChildId_ComputeIsReadOnly(global::LightSwitchApplication.Play e)
                {
                    bool result = false;
                    e.ChildId_IsReadOnly(ref result);
                    return result;
                }
                private static void _ChildId_Validate(global::LightSwitchApplication.Play e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.ChildId_Validate(r);
                }
                private static int _ChildId_GetImplementationValue(global::LightSwitchApplication.Play.DetailsClass d)
                {
                    return d.ImplementationEntity.ChildId;
                }
                private static void _ChildId_SetImplementationValue(global::LightSwitchApplication.Play.DetailsClass d, int v)
                {
                    d.ImplementationEntity.ChildId = v;
                }
                private static void _ChildId_OnValueChanged(global::LightSwitchApplication.Play e)
                {
                    e.ChildId_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string>.Entry
                    Title = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string>.Entry(
                        "Title",
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_Stub,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_ComputeIsReadOnly,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_Validate,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_GetImplementationValue,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_SetImplementationValue,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._Title_OnValueChanged);
                private static void _Title_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Play.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string>.Data> c, global::LightSwitchApplication.Play.DetailsClass d, object sf)
                {
                    c(d, ref d._Title, sf);
                }
                private static bool _Title_ComputeIsReadOnly(global::LightSwitchApplication.Play e)
                {
                    bool result = false;
                    e.Title_IsReadOnly(ref result);
                    return result;
                }
                private static void _Title_Validate(global::LightSwitchApplication.Play e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Title_Validate(r);
                }
                private static string _Title_GetImplementationValue(global::LightSwitchApplication.Play.DetailsClass d)
                {
                    return d.ImplementationEntity.Title;
                }
                private static void _Title_SetImplementationValue(global::LightSwitchApplication.Play.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Title = v;
                }
                private static void _Title_OnValueChanged(global::LightSwitchApplication.Play e)
                {
                    e.Title_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer>.Entry
                    PlayVolunteers = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer>.Entry(
                        "PlayVolunteers",
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayVolunteers_Stub,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayVolunteers_GetReferencedEntities,
                        global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties._PlayVolunteers_GetEntityCollection);
                private static void _PlayVolunteers_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Play.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer>.Data> c, global::LightSwitchApplication.Play.DetailsClass d, object sf)
                {
                    c(d, ref d._PlayVolunteers, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.PlayVolunteer> _PlayVolunteers_GetReferencedEntities(global::LightSwitchApplication.Play.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.PlayVolunteer, global::LightSwitchApplication.PlayVolunteer.DetailsClass>(global::LightSwitchApplication.Play.DetailsClass.PropertySetProperties.PlayVolunteers, ref d._PlayVolunteers);
                }
                private static global::System.Collections.IEnumerable _PlayVolunteers_GetEntityCollection(global::LightSwitchApplication.Play.DetailsClass d)
                {
                    return d.ImplementationEntity.PlayVolunteers;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Data _PlayId;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, int>.Data _ChildId;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, string>.Data _Title;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Play, global::LightSwitchApplication.Play.DetailsClass, global::LightSwitchApplication.PlayVolunteer>.Data _PlayVolunteers;
            
        }
    
        #endregion
    }
    
    #endregion
}
