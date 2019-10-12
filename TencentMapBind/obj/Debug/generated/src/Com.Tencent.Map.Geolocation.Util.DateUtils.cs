using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/util/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/util/DateUtils", typeof (DateUtils));
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

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='DateUtils']/method[@name='bbb08788c45327527041933a3f54c56b' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("bbb08788c45327527041933a3f54c56b", "(JJ)Z", "")]
		public static unsafe bool Bbb08788c45327527041933a3f54c56b (long p0, long p1)
		{
			const string __id = "bbb08788c45327527041933a3f54c56b.(JJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='DateUtils']/method[@name='f2593e4de50dde6467f44b48c4b8180d' and count(parameter)=0]"
		[Register ("f2593e4de50dde6467f44b48c4b8180d", "()J", "")]
		public static unsafe long F2593e4de50dde6467f44b48c4b8180d ()
		{
			const string __id = "f2593e4de50dde6467f44b48c4b8180d.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
