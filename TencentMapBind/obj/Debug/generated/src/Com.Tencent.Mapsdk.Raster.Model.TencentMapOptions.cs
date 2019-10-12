using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/TencentMapOptions", DoNotGenerateAcw=true)]
	public partial class TencentMapOptions : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/field[@name='LOGO_POSITION_BOTTOM_LEFT']"
		[Register ("LOGO_POSITION_BOTTOM_LEFT")]
		public const int LogoPositionBottomLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/field[@name='LOGO_POSITION_BOTTOM_RIGHT']"
		[Register ("LOGO_POSITION_BOTTOM_RIGHT")]
		public const int LogoPositionBottomRight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/field[@name='LOGO_POSITION_TOP_LEFT']"
		[Register ("LOGO_POSITION_TOP_LEFT")]
		public const int LogoPositionTopLeft = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/field[@name='LOGO_POSITION_TOP_RIGHT']"
		[Register ("LOGO_POSITION_TOP_RIGHT")]
		public const int LogoPositionTopRight = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/TencentMapOptions", typeof (TencentMapOptions));
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

		protected TencentMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/constructor[@name='TencentMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TencentMapOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isHandDrawMapEnable;
#pragma warning disable 0169
		static Delegate GetIsHandDrawMapEnableHandler ()
		{
			if (cb_isHandDrawMapEnable == null)
				cb_isHandDrawMapEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHandDrawMapEnable);
			return cb_isHandDrawMapEnable;
		}

		static bool n_IsHandDrawMapEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHandDrawMapEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHandDrawMapEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/method[@name='isHandDrawMapEnable' and count(parameter)=0]"
			[Register ("isHandDrawMapEnable", "()Z", "GetIsHandDrawMapEnableHandler")]
			get {
				const string __id = "isHandDrawMapEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_enableHandDrawMap_Z;
#pragma warning disable 0169
		static Delegate GetEnableHandDrawMap_ZHandler ()
		{
			if (cb_enableHandDrawMap_Z == null)
				cb_enableHandDrawMap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_EnableHandDrawMap_Z);
			return cb_enableHandDrawMap_Z;
		}

		static IntPtr n_EnableHandDrawMap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableHandDrawMap (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TencentMapOptions']/method[@name='enableHandDrawMap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableHandDrawMap", "(Z)Lcom/tencent/mapsdk/raster/model/TencentMapOptions;", "GetEnableHandDrawMap_ZHandler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions EnableHandDrawMap (bool p0)
		{
			const string __id = "enableHandDrawMap.(Z)Lcom/tencent/mapsdk/raster/model/TencentMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
