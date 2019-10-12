using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.tencent.tencentmap.mapsdk.map.OverlayItem"})]
	public abstract partial class ItemizedOverlay : global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos", DoNotGenerateAcw=true)]
		public sealed partial class BoundPos : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='Center']"
			[Register ("Center")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos Center {
				get {
					const string __id = "Center.Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='CenterBottom']"
			[Register ("CenterBottom")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos CenterBottom {
				get {
					const string __id = "CenterBottom.Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='Normal']"
			[Register ("Normal")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos Normal {
				get {
					const string __id = "Normal.Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos", typeof (BoundPos));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal BoundPos (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;", "")]
			public static unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos[] Values ()
			{
				const string __id = "values.()[Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$ItemsContainer", DoNotGenerateAcw=true)]
		public partial class ItemsContainer : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$ItemsContainer", typeof (ItemsContainer));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected ItemsContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/constructor[@name='ItemizedOverlay.ItemsContainer' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay']]"
			[Register (".ctor", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;)V", "")]
			public unsafe ItemsContainer (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
			static Delegate GetHandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
			{
				if (cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
					cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
				return cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			}

			static bool n_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleLongPress (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='HandleLongPress' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
			[Register ("HandleLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetHandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
			public virtual unsafe bool HandleLongPress (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
			{
				const string __id = "HandleLongPress.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
			static Delegate GetHandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
			{
				if (cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
					cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
				return cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			}

			static bool n_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleTap (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='HandleTap' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
			[Register ("HandleTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetHandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
			public virtual unsafe bool HandleTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
			{
				const string __id = "HandleTap.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
			{
				if (cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
					cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Integer_Ljava_lang_Integer_);
				return cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_;
			}

			static int n_Compare_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer']]"
			[Register ("compare", "(Ljava/lang/Integer;Ljava/lang/Integer;)I", "GetCompare_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
			public virtual unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				const string __id = "compare.(Ljava/lang/Integer;Ljava/lang/Integer;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_count;
#pragma warning disable 0169
			static Delegate GetCountHandler ()
			{
				if (cb_count == null)
					cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
				return cb_count;
			}

			static int n_Count (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='count' and count(parameter)=0]"
			[Register ("count", "()I", "GetCountHandler")]
			public virtual unsafe int Count ()
			{
				const string __id = "count.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getPosByRank_I;
#pragma warning disable 0169
			static Delegate GetGetPosByRank_IHandler ()
			{
				if (cb_getPosByRank_I == null)
					cb_getPosByRank_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPosByRank_I);
				return cb_getPosByRank_I;
			}

			static int n_GetPosByRank_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetPosByRank (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='getPosByRank' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getPosByRank", "(I)I", "GetGetPosByRank_IHandler")]
			public virtual unsafe int GetPosByRank (int p0)
			{
				const string __id = "getPosByRank.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getSpan_Z;
#pragma warning disable 0169
			static Delegate GetGetSpan_ZHandler ()
			{
				if (cb_getSpan_Z == null)
					cb_getSpan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_GetSpan_Z);
				return cb_getSpan_Z;
			}

			static int n_GetSpan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSpan (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='getSpan' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("getSpan", "(Z)I", "GetGetSpan_ZHandler")]
			public virtual unsafe int GetSpan (bool p0)
			{
				const string __id = "getSpan.(Z)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_release;
#pragma warning disable 0169
			static Delegate GetReleaseHandler ()
			{
				if (cb_release == null)
					cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
				return cb_release;
			}

			static void n_Release (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler")]
			public virtual unsafe void Release ()
			{
				const string __id = "release.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='ItemizedOverlay.OnFocusChangeListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay/IOnFocusChangeListenerInvoker")]
		public partial interface IOnFocusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='ItemizedOverlay.OnFocusChangeListener']/method[@name='onFocusChanged' and count(parameter)=2 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay&lt;?&gt;'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.OverlayItem']]"
			[Register ("onFocusChanged", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V", "GetOnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay/IOnFocusChangeListenerInvoker, TencentMapBind")]
			void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener", DoNotGenerateAcw=true)]
		internal class IOnFocusChangeListenerInvoker : global::Java.Lang.Object, IOnFocusChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener", typeof (IOnFocusChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnFocusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFocusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.ItemizedOverlay.OnFocusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFocusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
#pragma warning disable 0169
			static Delegate GetOnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler ()
			{
				if (cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == null)
					cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_);
				return cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
			}

			static void n_OnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFocusChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
			public unsafe void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				if (id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == IntPtr.Zero)
					id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "onFocusChanged", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_, __args);
			}

		}

		// event args for com.tencent.tencentmap.mapsdk.map.ItemizedOverlay.OnFocusChangeListener.onFocusChanged
		public partial class FocusChangeEventArgs : global::System.EventArgs {

			public FocusChangeEventArgs (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0;
			public global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay P0 {
				get { return p0; }
			}

			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1;
			public global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/ItemizedOverlay_OnFocusChangeListenerImplementor")]
		internal sealed partial class IOnFocusChangeListenerImplementor : global::Java.Lang.Object, IOnFocusChangeListener {

			object sender;

			public IOnFocusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/ItemizedOverlay_OnFocusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FocusChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FocusChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnFocusChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", typeof (ItemizedOverlay));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ItemizedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ItemizedOverlay (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe ItemizedOverlay (global::Android.Graphics.Drawables.Drawable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetGetCenterHandler")]
			get {
				const string __id = "getCenter.()Lcom/tencent/mapsdk/raster/model/GeoPoint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFocus;
#pragma warning disable 0169
		static Delegate GetGetFocusHandler ()
		{
			if (cb_getFocus == null)
				cb_getFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocus);
			return cb_getFocus;
		}

		static IntPtr n_GetFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Focus);
		}
#pragma warning restore 0169

		static Delegate cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetSetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler ()
		{
			if (cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == null)
				cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_);
			return cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
		}

		static void n_SetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Focus = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Focus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getFocus' and count(parameter)=0]"
			[Register ("getFocus", "()Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetGetFocusHandler")]
			get {
				const string __id = "getFocus.()Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setFocus' and count(parameter)=1 and parameter[1][@type='Item']]"
			[Register ("setFocus", "(Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V", "GetSetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler")]
			set {
				const string __id = "setFocus.(Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe int LastFocusedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLastFocusedIndex' and count(parameter)=0]"
			[Register ("getLastFocusedIndex", "()I", "GetGetLastFocusedIndexHandler")]
			get {
				const string __id = "getLastFocusedIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLatSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLatSpanE6Handler ()
		{
			if (cb_getLatSpanE6 == null)
				cb_getLatSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatSpanE6);
			return cb_getLatSpanE6;
		}

		static int n_GetLatSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatSpanE6;
		}
#pragma warning restore 0169

		public virtual unsafe int LatSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLatSpanE6' and count(parameter)=0]"
			[Register ("getLatSpanE6", "()I", "GetGetLatSpanE6Handler")]
			get {
				const string __id = "getLatSpanE6.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLonSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLonSpanE6Handler ()
		{
			if (cb_getLonSpanE6 == null)
				cb_getLonSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLonSpanE6);
			return cb_getLonSpanE6;
		}

		static int n_GetLonSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonSpanE6;
		}
#pragma warning restore 0169

		public virtual unsafe int LonSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLonSpanE6' and count(parameter)=0]"
			[Register ("getLonSpanE6", "()I", "GetGetLonSpanE6Handler")]
			get {
				const string __id = "getLonSpanE6.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isShadowEnable;
#pragma warning disable 0169
		static Delegate GetIsShadowEnableHandler ()
		{
			if (cb_isShadowEnable == null)
				cb_isShadowEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShadowEnable);
			return cb_isShadowEnable;
		}

		static bool n_IsShadowEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetShadowEnable_ZHandler ()
		{
			if (cb_setShadowEnable_Z == null)
				cb_setShadowEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShadowEnable_Z);
			return cb_setShadowEnable_Z;
		}

		static void n_SetShadowEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowEnable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShadowEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='isShadowEnable' and count(parameter)=0]"
			[Register ("isShadowEnable", "()Z", "GetIsShadowEnableHandler")]
			get {
				const string __id = "isShadowEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setShadowEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShadowEnable", "(Z)V", "GetSetShadowEnable_ZHandler")]
			set {
				const string __id = "setShadowEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='boundCenter' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("boundCenter", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable BoundCenter (global::Android.Graphics.Drawables.Drawable p0)
		{
			const string __id = "boundCenter.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='boundCenterBottom' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("boundCenterBottom", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable BoundCenterBottom (global::Android.Graphics.Drawables.Drawable p0)
		{
			const string __id = "boundCenterBottom.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createItem_I;
#pragma warning disable 0169
		static Delegate GetCreateItem_IHandler ()
		{
			if (cb_createItem_I == null)
				cb_createItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateItem_I);
			return cb_createItem_I;
		}

		static IntPtr n_CreateItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItem (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetCreateItem_IHandler")]
		protected abstract global::Java.Lang.Object CreateItem (int p0);

		static Delegate cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='draw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getIndexToDraw_I;
#pragma warning disable 0169
		static Delegate GetGetIndexToDraw_IHandler ()
		{
			if (cb_getIndexToDraw_I == null)
				cb_getIndexToDraw_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndexToDraw_I);
			return cb_getIndexToDraw_I;
		}

		static int n_GetIndexToDraw_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexToDraw (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getIndexToDraw' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexToDraw", "(I)I", "GetGetIndexToDraw_IHandler")]
		protected virtual unsafe int GetIndexToDraw (int p0)
		{
			const string __id = "getIndexToDraw.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "")]
		public unsafe global::Java.Lang.Object GetItem (int p0)
		{
			const string __id = "getItem.(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextFocus_Z;
#pragma warning disable 0169
		static Delegate GetNextFocus_ZHandler ()
		{
			if (cb_nextFocus_Z == null)
				cb_nextFocus_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_NextFocus_Z);
			return cb_nextFocus_Z;
		}

		static IntPtr n_NextFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextFocus (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='nextFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("nextFocus", "(Z)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetNextFocus_ZHandler")]
		public virtual unsafe global::Java.Lang.Object NextFocus (bool p0)
		{
			const string __id = "nextFocus.(Z)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTap_I;
#pragma warning disable 0169
		static Delegate GetOnTap_IHandler ()
		{
			if (cb_onTap_I == null)
				cb_onTap_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OnTap_I);
			return cb_onTap_I;
		}

		static bool n_OnTap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnTap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='onTap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTap", "(I)Z", "GetOnTap_IHandler")]
		protected virtual unsafe bool OnTap (int p0)
		{
			const string __id = "onTap.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='populate' and count(parameter)=0]"
		[Register ("populate", "()V", "")]
		protected unsafe void Populate ()
		{
			const string __id = "populate.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setDrawFocusedItem_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawFocusedItem_ZHandler ()
		{
			if (cb_setDrawFocusedItem_Z == null)
				cb_setDrawFocusedItem_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawFocusedItem_Z);
			return cb_setDrawFocusedItem_Z;
		}

		static void n_SetDrawFocusedItem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawFocusedItem (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setDrawFocusedItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawFocusedItem", "(Z)V", "GetSetDrawFocusedItem_ZHandler")]
		public virtual unsafe void SetDrawFocusedItem (bool p0)
		{
			const string __id = "setDrawFocusedItem.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLastFocusedIndex_I;
#pragma warning disable 0169
		static Delegate GetSetLastFocusedIndex_IHandler ()
		{
			if (cb_setLastFocusedIndex_I == null)
				cb_setLastFocusedIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLastFocusedIndex_I);
			return cb_setLastFocusedIndex_I;
		}

		static void n_SetLastFocusedIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastFocusedIndex (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setLastFocusedIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLastFocusedIndex", "(I)V", "GetSetLastFocusedIndex_IHandler")]
		protected virtual unsafe void SetLastFocusedIndex (int p0)
		{
			const string __id = "setLastFocusedIndex.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_Handler ()
		{
			if (cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ == null)
				cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_);
			return cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_;
		}

		static void n_SetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFocusChangeListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setOnFocusChangeListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay.OnFocusChangeListener']]"
		[Register ("setOnFocusChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener;)V", "GetSetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_Handler")]
		public virtual unsafe void SetOnFocusChangeListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener p0)
		{
			const string __id = "setOnFocusChangeListener.(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public abstract int Size ();

#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.FocusChangeEventArgs> FocusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						__CreateIOnFocusChangeListenerImplementor,
						SetOnFocusChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor.__IsEmpty,
						__v => SetOnFocusChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFocusChangeListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor __CreateIOnFocusChangeListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	internal partial class ItemizedOverlayInvoker : ItemizedOverlay {

		public ItemizedOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", typeof (ItemizedOverlayInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetCreateItem_IHandler")]
		protected override unsafe global::Java.Lang.Object CreateItem (int p0)
		{
			const string __id = "createItem.(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

}
