using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='CameraUpdate']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/CameraUpdate", DoNotGenerateAcw=true)]
	public sealed partial class CameraUpdate : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/CameraUpdate", typeof (CameraUpdate));
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

		internal CameraUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
