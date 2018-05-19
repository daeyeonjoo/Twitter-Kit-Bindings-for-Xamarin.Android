using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Twitter.Sdk.Android.Tweetui {

    public partial class TweetTimelineRecyclerViewAdapter
    {
        public override unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
        {
            if (id_onBindViewHolder_Lcom_twitter_sdk_android_tweetui_TweetTimelineRecyclerViewAdapter_TweetViewHolder_I == IntPtr.Zero)
                id_onBindViewHolder_Lcom_twitter_sdk_android_tweetui_TweetTimelineRecyclerViewAdapter_TweetViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Lcom/twitter/sdk/android/tweetui/TweetTimelineRecyclerViewAdapter$TweetViewHolder;I)V");
            try {
                JValue* __args = stackalloc JValue [2];
                __args [0] = new JValue (p0);
                __args [1] = new JValue (p1);

                if (((object) this).GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Lcom_twitter_sdk_android_tweetui_TweetTimelineRecyclerViewAdapter_TweetViewHolder_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Lcom/twitter/sdk/android/tweetui/TweetTimelineRecyclerViewAdapter$TweetViewHolder;I)V"), __args);
            } finally {
            }
        }
    }
}