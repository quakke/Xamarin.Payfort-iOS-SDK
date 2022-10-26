using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PassKit;
using UIKit;

namespace PayFortSDK
{
	// @interface PFKJVFloatLabeledTextField : UITextField
	[BaseType(typeof(UITextField))]
	interface PFKJVFloatLabeledTextField
	{
		// @property (readonly, nonatomic, strong) UILabel * floatingLabel;
		[Export("floatingLabel", ArgumentSemantic.Strong)]
		UILabel FloatingLabel { get; }

		// @property (nonatomic) CGFloat floatingLabelYPadding;
		[Export("floatingLabelYPadding")]
		nfloat FloatingLabelYPadding { get; set; }

		// @property (nonatomic) CGFloat floatingLabelXPadding;
		[Export("floatingLabelXPadding")]
		nfloat FloatingLabelXPadding { get; set; }

		// @property (nonatomic) CGFloat floatingLabelReductionRatio;
		[Export("floatingLabelReductionRatio")]
		nfloat FloatingLabelReductionRatio { get; set; }

		// @property (nonatomic) CGFloat placeholderYPadding;
		[Export("placeholderYPadding")]
		nfloat PlaceholderYPadding { get; set; }

		// @property (nonatomic, strong) UIFont * floatingLabelFont;
		[Export("floatingLabelFont", ArgumentSemantic.Strong)]
		UIFont FloatingLabelFont { get; set; }

		// @property (nonatomic, strong) UIColor * floatingLabelTextColor;
		[Export("floatingLabelTextColor", ArgumentSemantic.Strong)]
		UIColor FloatingLabelTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * floatingLabelActiveTextColor;
		[Export("floatingLabelActiveTextColor", ArgumentSemantic.Strong)]
		UIColor FloatingLabelActiveTextColor { get; set; }

		// @property (assign, nonatomic) BOOL animateEvenIfNotFirstResponder;
		[Export("animateEvenIfNotFirstResponder")]
		bool AnimateEvenIfNotFirstResponder { get; set; }

		// @property (assign, nonatomic) NSTimeInterval floatingLabelShowAnimationDuration;
		[Export("floatingLabelShowAnimationDuration")]
		double FloatingLabelShowAnimationDuration { get; set; }

		// @property (assign, nonatomic) NSTimeInterval floatingLabelHideAnimationDuration;
		[Export("floatingLabelHideAnimationDuration")]
		double FloatingLabelHideAnimationDuration { get; set; }

		// @property (assign, nonatomic) BOOL adjustsClearButtonRect;
		[Export("adjustsClearButtonRect")]
		bool AdjustsClearButtonRect { get; set; }

		// @property (assign, nonatomic) BOOL keepBaseline;
		[Export("keepBaseline")]
		bool KeepBaseline { get; set; }

		// @property (assign, nonatomic) BOOL alwaysShowFloatingLabel;
		[Export("alwaysShowFloatingLabel")]
		bool AlwaysShowFloatingLabel { get; set; }

		// @property (nonatomic, strong) UIColor * placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// -(void)setPlaceholder:(NSString *)placeholder floatingTitle:(NSString *)floatingTitle;
		[Export("setPlaceholder:floatingTitle:")]
		void SetPlaceholder(string placeholder, string floatingTitle);

		// -(void)setAttributedPlaceholder:(NSAttributedString *)attributedPlaceholder floatingTitle:(NSString *)floatingTitle;
		[Export("setAttributedPlaceholder:floatingTitle:")]
		void SetAttributedPlaceholder(NSAttributedString attributedPlaceholder, string floatingTitle);
	}

	// @interface CardContainer : UIView
	[BaseType(typeof(UIView), Name = "_TtC10PayFortSDK13CardContainer")]
	interface CardContainer
	{
		// @property (nonatomic, weak) UILabel * _Null_unspecified errorLabel __attribute__((iboutlet));
		[Export("errorLabel", ArgumentSemantic.Weak)]
		UILabel ErrorLabel { get; set; }

		// -(void)awakeFromNib __attribute__((objc_requires_super));
		[Export("awakeFromNib")]
		[RequiresSuper]
		void AwakeFromNib();

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSCoder coder);
	}

	// @interface CVCNumberView : CardContainer
	[BaseType(typeof(CardContainer), Name = "_TtC10PayFortSDK13CVCNumberView")]
	interface CVCNumberView
	{
	}

	// @interface PayFortSDK_Swift_236 (CardContainer) <UITextFieldDelegate>
	[Category]
	[BaseType(typeof(CardContainer))]
	interface CardContainer_PayFortSDK_Swift_236 : IUITextFieldDelegate
	{
		// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Export("textField:shouldChangeCharactersInRange:replacementString:")]
		bool TextField(UITextField textField, NSRange range, string @string);

		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField reason:(UITextFieldDidEndEditingReason)reason;
		[Export("textFieldDidEndEditing:reason:")]
		void TextFieldDidEndEditing(UITextField textField, UITextFieldDidEndEditingReason reason);
	}

	// @interface CardNumberView : CardContainer
	[BaseType(typeof(CardContainer), Name = "_TtC10PayFortSDK14CardNumberView")]
	interface CardNumberView
	{
	}

	// @interface ExpiryDateView : CardContainer
	[BaseType(typeof(CardContainer), Name = "_TtC10PayFortSDK14ExpiryDateView")]
	interface ExpiryDateView
	{
	}

	// @interface HolderNameView : CardContainer
	[BaseType(typeof(CardContainer), Name = "_TtC10PayFortSDK14HolderNameView")]
	interface HolderNameView
	{
	}

	// @interface PayButton : UIButton
	[BaseType(typeof(UIButton), Name = "_TtC10PayFortSDK9PayButton")]
	interface PayButton
	{
		// -(void)setupWith:(NSDictionary<NSString *,NSString *> * _Nonnull)request enviroment:(enum PayFortEnviroment)enviroment payButtonBuilder:(PayComponents * _Nonnull)payButtonBuilder viewController:(UIViewController * _Nonnull)viewController showLoading:(void (^ _Nonnull)(void))showLoading success:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull))success faild:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull, NSString * _Nonnull))faild;
		[Export("setupWith:enviroment:payButtonBuilder:viewController:showLoading:success:faild:")]
		void SetupWith(NSDictionary<NSString, NSString> request, PayFortEnviroment enviroment, PayComponents payButtonBuilder, UIViewController viewController, Action showLoading, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>> success, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>, NSString> faild);

		// -(void)setupWith:(NSDictionary<NSString *,NSString *> * _Nonnull)request enviroment:(enum PayFortEnviroment)enviroment viewController:(UIViewController * _Nonnull)viewController showLoading:(void (^ _Nonnull)(void))showLoading success:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull))success faild:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull, NSString * _Nonnull))faild;
		[Export("setupWith:enviroment:viewController:showLoading:success:faild:")]
		void SetupWith(NSDictionary<NSString, NSString> request, PayFortEnviroment enviroment, UIViewController viewController, Action showLoading, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>> success, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>, NSString> faild);

		// -(void)updateRequestWithRequest:(NSDictionary<NSString *,NSString *> * _Nonnull)request;
		[Export("updateRequestWithRequest:")]
		void UpdateRequestWithRequest(NSDictionary<NSString, NSString> request);

		// -(void)isRememberEnabled:(BOOL)enabled;
		[Export("isRememberEnabled:")]
		void IsRememberEnabled(bool enabled);
	}

	// @interface PayComponents : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC10PayFortSDK13PayComponents")]
	[DisableDefaultCtor]
	interface PayComponents
	{
	}

	// @interface PayFortController : UIViewController
	[BaseType(typeof(UIViewController), Name = "_TtC10PayFortSDK17PayFortController")]
	interface PayFortController
	{
		// @property (nonatomic) BOOL isShowResponsePage;
		[Export("isShowResponsePage")]
		bool IsShowResponsePage { get; set; }

		// @property (nonatomic) BOOL hideLoading;
		[Export("hideLoading")]
		bool HideLoading { get; set; }

		// @property (nonatomic) BOOL presentAsDefault;
		[Export("presentAsDefault")]
		bool PresentAsDefault { get; set; }

		// -(instancetype _Nonnull)initWithEnviroment:(enum PayFortEnviroment)enviroment __attribute__((objc_designated_initializer));
		[Export("initWithEnviroment:")]
		[DesignatedInitializer]
		IntPtr Constructor(PayFortEnviroment enviroment);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSCoder coder);

		// -(void)viewDidLoad;
		[Export("viewDidLoad")]
		void ViewDidLoad();

		// -(NSString * _Nonnull)getUDID __attribute__((warn_unused_result("")));
		[Export("getUDID")]
		string UDID { get; }

		// -(void)callValidateAPIWith:(NSDictionary<NSString *,NSString *> * _Nonnull)request showLoading:(void (^ _Nonnull)(void))showLoading success:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull))success faild:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull, NSString * _Nonnull))faild;
		[Export("callValidateAPIWith:showLoading:success:faild:")]
		void CallValidateAPIWith(NSDictionary<NSString, NSString> request, Action showLoading, Action<NSDictionary<NSString, NSString>> success, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>, NSString> faild);

		// -(void)callPayFortWithRequest:(NSDictionary<NSString *,NSString *> * _Nonnull)withRequest currentViewController:(UIViewController * _Nonnull)currentViewController success:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull))success canceled:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull))canceled faild:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull, NSString * _Nonnull))faild;
		[Export("callPayFortWithRequest:currentViewController:success:canceled:faild:")]
		void CallPayFortWithRequest(NSDictionary<NSString, NSString> withRequest, UIViewController currentViewController, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>> success, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>> canceled, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>, NSString> faild);

		// -(void)callPayFortForApplePayWithRequest:(NSDictionary<NSString *,NSString *> * _Nonnull)withRequest applePayPayment:(PKPayment * _Nonnull)applePayPayment currentViewController:(UIViewController * _Nonnull)currentViewController success:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull))success faild:(void (^ _Nonnull)(NSDictionary<NSString *,NSString *> * _Nonnull, NSDictionary<NSString *,NSString *> * _Nonnull, NSString * _Nonnull))faild;
		[Export("callPayFortForApplePayWithRequest:applePayPayment:currentViewController:success:faild:")]
		void CallPayFortForApplePayWithRequest(NSDictionary<NSString, NSString> withRequest, PKPayment applePayPayment, UIViewController currentViewController, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>> success, Action<NSDictionary<NSString, NSString>, NSDictionary<NSString, NSString>, NSString> faild);

		// -(void)setPayFortCustomViewNib:(NSString * _Nonnull)viewNib;
		[Export("setPayFortCustomViewNib:")]
		void SetPayFortCustomViewNib(string viewNib);
	}

	// @interface PayFortView : UIView
	[BaseType(typeof(UIView), Name = "_TtC10PayFortSDK11PayFortView")]
	interface PayFortView
	{
		// @property (nonatomic, weak) PFKJVFloatLabeledTextField * _Null_unspecified CardNumberTxt __attribute__((iboutlet));
		[Export("CardNumberTxt", ArgumentSemantic.Weak)]
		PFKJVFloatLabeledTextField CardNumberTxt { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified cardNumberErrorlbl __attribute__((iboutlet));
		[Export("cardNumberErrorlbl", ArgumentSemantic.Weak)]
		UILabel CardNumberErrorlbl { get; set; }

		// @property (nonatomic, weak) PFKJVFloatLabeledTextField * _Null_unspecified CardNameTxt __attribute__((iboutlet));
		[Export("CardNameTxt", ArgumentSemantic.Weak)]
		PFKJVFloatLabeledTextField CardNameTxt { get; set; }

		// @property (nonatomic, weak) PFKJVFloatLabeledTextField * _Null_unspecified CVCNumberTxt __attribute__((iboutlet));
		[Export("CVCNumberTxt", ArgumentSemantic.Weak)]
		PFKJVFloatLabeledTextField CVCNumberTxt { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified cVCNumberErrorlbl __attribute__((iboutlet));
		[Export("cVCNumberErrorlbl", ArgumentSemantic.Weak)]
		UILabel CVCNumberErrorlbl { get; set; }

		// @property (nonatomic, weak) PFKJVFloatLabeledTextField * _Null_unspecified ExpDateTxt __attribute__((iboutlet));
		[Export("ExpDateTxt", ArgumentSemantic.Weak)]
		PFKJVFloatLabeledTextField ExpDateTxt { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified expDateErrorlbl __attribute__((iboutlet));
		[Export("expDateErrorlbl", ArgumentSemantic.Weak)]
		UILabel ExpDateErrorlbl { get; set; }

		// @property (nonatomic, weak) UIView * _Null_unspecified titleView __attribute__((iboutlet));
		[Export("titleView", ArgumentSemantic.Weak)]
		UIView TitleView { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified titleLbl __attribute__((iboutlet));
		[Export("titleLbl", ArgumentSemantic.Weak)]
		UILabel TitleLbl { get; set; }

		// @property (nonatomic, weak) UIButton * _Null_unspecified BackBtn __attribute__((iboutlet));
		[Export("BackBtn", ArgumentSemantic.Weak)]
		UIButton BackBtn { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * _Null_unspecified headerHeight __attribute__((iboutlet));
		[Export("headerHeight", ArgumentSemantic.Weak)]
		NSLayoutConstraint HeaderHeight { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified PriceLbl __attribute__((iboutlet));
		[Export("PriceLbl", ArgumentSemantic.Weak)]
		UILabel PriceLbl { get; set; }

		// @property (nonatomic, weak) UISwitch * _Null_unspecified savedCardSwitch __attribute__((iboutlet));
		[Export("savedCardSwitch", ArgumentSemantic.Weak)]
		UISwitch SavedCardSwitch { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified saveCardLbl __attribute__((iboutlet));
		[Export("saveCardLbl", ArgumentSemantic.Weak)]
		UILabel SaveCardLbl { get; set; }

		// @property (nonatomic, weak) UIImageView * _Null_unspecified imageCard __attribute__((iboutlet));
		[Export("imageCard", ArgumentSemantic.Weak)]
		UIImageView ImageCard { get; set; }

		// @property (nonatomic, weak) UIView * _Null_unspecified SaveCardView __attribute__((iboutlet));
		[Export("SaveCardView", ArgumentSemantic.Weak)]
		UIView SaveCardView { get; set; }

		// @property (nonatomic, weak) UIButton * _Null_unspecified paymentBtn __attribute__((iboutlet));
		[Export("paymentBtn", ArgumentSemantic.Weak)]
		UIButton PaymentBtn { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSCoder coder);
	}

	// @interface Property : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC10PayFortSDK8Property")]
	interface Property
	{
		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable fontStyle;
		[NullAllowed, Export("fontStyle", ArgumentSemantic.Strong)]
		UIFont FontStyle { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable errorText;
		[NullAllowed, Export("errorText")]
		string ErrorText { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable errorFontStyle;
		[NullAllowed, Export("errorFontStyle", ArgumentSemantic.Strong)]
		UIFont ErrorFontStyle { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable errorTextColor;
		[NullAllowed, Export("errorTextColor", ArgumentSemantic.Strong)]
		UIColor ErrorTextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable titleText;
		[NullAllowed, Export("titleText")]
		string TitleText { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleTextColor;
		[NullAllowed, Export("titleTextColor", ArgumentSemantic.Strong)]
		UIColor TitleTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleErrorTextColor;
		[NullAllowed, Export("titleErrorTextColor", ArgumentSemantic.Strong)]
		UIColor TitleErrorTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable titleFontStyle;
		[NullAllowed, Export("titleFontStyle", ArgumentSemantic.Strong)]
		UIFont TitleFontStyle { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern double PayFortVersionNumber;
		[Field("PayFortVersionNumber", "__Internal")]
		double PayFortVersionNumber { get; }

		// extern const unsigned char[] PayFortVersionString;
		[Field("PayFortVersionString", "__Internal")]
		IntPtr PayFortVersionString { get; }
    }
}
