using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_CENTER_BOTTOM']"
		[Register ("LOGO_POSITION_CENTER_BOTTOM")]
		public const int LogoPositionCenterBottom = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_CENTER_TOP']"
		[Register ("LOGO_POSITION_CENTER_TOP")]
		public const int LogoPositionCenterTop = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_LEFT_BOTTOM']"
		[Register ("LOGO_POSITION_LEFT_BOTTOM")]
		public const int LogoPositionLeftBottom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_LEFT_TOP']"
		[Register ("LOGO_POSITION_LEFT_TOP")]
		public const int LogoPositionLeftTop = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_RIGHT_BOTTOM']"
		[Register ("LOGO_POSITION_RIGHT_BOTTOM")]
		public const int LogoPositionRightBottom = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_RIGHT_TOP']"
		[Register ("LOGO_POSITION_RIGHT_TOP")]
		public const int LogoPositionRightTop = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_CENTER_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_CENTER_BOTTOM")]
		public const int ScaleviewPositionCenterBottom = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_LEFT_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_LEFT_BOTTOM")]
		public const int ScaleviewPositionLeftBottom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_RIGHT_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_RIGHT_BOTTOM")]
		public const int ScaleviewPositionRightBottom = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/UiSettings", typeof (UiSettings));
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

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool AnimationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isAnimationEnabled' and count(parameter)=0]"
			[Register ("isAnimationEnabled", "()Z", "GetIsAnimationEnabledHandler")]
			get {
				const string __id = "isAnimationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnimationEnabled", "(Z)V", "GetSetAnimationEnabled_ZHandler")]
			set {
				const string __id = "setAnimationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		protected unsafe bool IsScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				const string __id = "isScrollGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe bool IsZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				const string __id = "isZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler")]
			get {
				const string __id = "getLogoPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool ScaleControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isScaleControlsEnabled' and count(parameter)=0]"
			[Register ("isScaleControlsEnabled", "()Z", "GetIsScaleControlsEnabledHandler")]
			get {
				const string __id = "isScaleControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScaleControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleControlsEnabled", "(Z)V", "GetSetScaleControlsEnabled_ZHandler")]
			set {
				const string __id = "setScaleControlsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		protected unsafe int ScaleViewPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='getScaleViewPosition' and count(parameter)=0]"
			[Register ("getScaleViewPosition", "()I", "GetGetScaleViewPositionHandler")]
			get {
				const string __id = "getScaleViewPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		protected unsafe void SetAllGesturesEnabled (bool p0)
		{
			const string __id = "setAllGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogoPosition", "(I)V", "")]
		public unsafe void SetLogoPosition (int p0)
		{
			const string __id = "setLogoPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setLogoPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("setLogoPosition", "(I[I)V", "")]
		public unsafe void SetLogoPosition (int p0, int[] p1)
		{
			const string __id = "setLogoPosition.(I[I)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setLogoScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLogoScale", "(F)V", "")]
		public unsafe void SetLogoScale (float p0)
		{
			const string __id = "setLogoScale.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScaleViewPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScaleViewPosition", "(I)V", "")]
		public unsafe void SetScaleViewPosition (int p0)
		{
			const string __id = "setScaleViewPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScrollGesturesEnabled", "(Z)V", "")]
		public unsafe void SetScrollGesturesEnabled (bool p0)
		{
			const string __id = "setScrollGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZoomGesturesEnabled", "(Z)V", "")]
		public unsafe void SetZoomGesturesEnabled (bool p0)
		{
			const string __id = "setZoomGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
