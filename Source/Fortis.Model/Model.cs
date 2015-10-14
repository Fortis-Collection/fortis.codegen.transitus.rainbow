#region Contest (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contest</para>
	/// <para>ID: {0484C694-D9F8-4D63-952F-06F0F1A64462}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Contests/Contest</para>
	/// </summary>
	[TemplateMapping("{0484C694-D9F8-4D63-952F-06F0F1A64462}", "InterfaceMap")]
	public partial interface IContest : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Contest</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contest_header_t")]
		ITextFieldWrapper ContestHeader { get; }

    	/// <summary>
		/// <para>Template: Contest</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contest_header")]
 		string ContestHeaderValue { get; }
    	/// <summary>
		/// <para>Template: Contest</para><para>Field: ContestImage</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper ContestImage { get; }
 		string ContestImageValue { get; }
    	/// <summary>
		/// <para>Template: Contest</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para>
        /// </summary>
		[IndexField("contest_video_sm")]
		IListFieldWrapper ContestVideo { get; }

    	/// <summary>
		/// <para>Template: Contest</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para>
        /// </summary>
		[IndexField("contest_video")]
 		IEnumerable<Guid> ContestVideoValue { get; }
    	/// <summary>
		/// <para>Template: Contest</para><para>Field: Context</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("context_s")]
		ILinkFieldWrapper Context { get; }

    	/// <summary>
		/// <para>Template: Contest</para><para>Field: Context</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("context")]
 		Guid ContextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Contests/Contest</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0484C694-D9F8-4D63-952F-06F0F1A64462}", typeof(Guid))]
	[TemplateMapping("{0484C694-D9F8-4D63-952F-06F0F1A64462}", "")]
	public partial class Contest : CustomItemWrapper, IContest
	{
		private Item _item = null;

		public Contest(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Contest(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Contest(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Contest(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Contest</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contest_header_t")]
		public virtual ITextFieldWrapper ContestHeader
		{
			get { return GetField<TextFieldWrapper>("Contest Header", "contest_header_t"); }
		}

		/// <summary><para>Template: Contest</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contest_header")]
 		public string ContestHeaderValue
		{
					get { return ContestHeader.Value; }
				}
		/// <summary><para>Template: Contest</para><para>Field: ContestImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContestImage
		{
			get { return GetField<ImageFieldWrapper>("Contest Image"); }
		}

		/// <summary><para>Template: Contest</para><para>Field: ContestImage</para><para>Data type: Image</para></summary>
 		public string ContestImageValue
		{
					get { return ContestImage.Value; }
				}
		/// <summary><para>Template: Contest</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("contest_video_sm")]
		public virtual IListFieldWrapper ContestVideo
		{
			get { return GetField<ListFieldWrapper>("Contest Video", "contest_video_sm"); }
		}

		/// <summary><para>Template: Contest</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("contest_video")]
 		public IEnumerable<Guid> ContestVideoValue
		{
					get { return ContestVideo.Value; }
				}
		/// <summary><para>Template: Contest</para><para>Field: Context</para><para>Data type: Droptree</para></summary>
		[IndexField("context_s")]
		public virtual ILinkFieldWrapper Context
		{
			get { return GetField<LinkFieldWrapper>("Context", "context_s"); }
		}

		/// <summary><para>Template: Contest</para><para>Field: Context</para><para>Data type: Droptree</para></summary>
		[IndexField("context")]
 		public Guid ContextValue
		{
					get { return Context.Value; }
				}
	
	}
}
#endregion
#region Child Content Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Child Content Page</para>
	/// <para>ID: {04B42251-36AB-44F0-BC43-F606988BDD11}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Child Content Page</para>
	/// </summary>
	[TemplateMapping("{04B42251-36AB-44F0-BC43-F606988BDD11}", "InterfaceMap")]
	public partial interface IChildContentPage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IContentPage, LM.Model.Templates.PokerCentral.ISponsors	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Child Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{04B42251-36AB-44F0-BC43-F606988BDD11}", typeof(Guid))]
	[TemplateMapping("{04B42251-36AB-44F0-BC43-F606988BDD11}", "")]
	public partial class ChildContentPage : CustomItemWrapper, IChildContentPage
	{
		private Item _item = null;

		public ChildContentPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ChildContentPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ChildContentPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ChildContentPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: Child Content Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Child Content Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region Pdf (ScSystem)
namespace LM.Model.Templates.ScSystem
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Pdf</para>
	/// <para>ID: {0603F166-35B8-469F-8123-E8D87BEDC171}</para>
	/// <para>/sitecore/templates/System/Media/Unversioned/Pdf</para>
	/// </summary>
	[TemplateMapping("{0603F166-35B8-469F-8123-E8D87BEDC171}", "InterfaceMap")]
	public partial interface IPdf : ICustomItemWrapper , LM.Model.Templates.ScSystem.IDocument	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/System/Media/Unversioned/Pdf</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0603F166-35B8-469F-8123-E8D87BEDC171}", typeof(Guid))]
	[TemplateMapping("{0603F166-35B8-469F-8123-E8D87BEDC171}", "")]
	public partial class Pdf : CustomItemWrapper, IPdf
	{
		private Item _item = null;

		public Pdf(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Pdf(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Pdf(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Pdf(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Pdf</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension_t")]
		public virtual ITextFieldWrapper Extension
		{
			get { return GetField<TextFieldWrapper>("Extension", "extension_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension")]
 		public string ExtensionValue
		{
					get { return Extension.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
 		public string KeywordsValue
		{
					get { return Keywords.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type_t")]
		public virtual ITextFieldWrapper MimeType
		{
			get { return GetField<TextFieldWrapper>("Mime Type", "mime_type_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type")]
 		public string MimeTypeValue
		{
					get { return MimeType.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size_t")]
		public virtual ITextFieldWrapper Size
		{
			get { return GetField<TextFieldWrapper>("Size", "size_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size")]
 		public string SizeValue
		{
					get { return Size.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
					get { return Title.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode_t")]
		public virtual ITextFieldWrapper CountryCode
		{
			get { return GetField<TextFieldWrapper>("CountryCode", "countrycode_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode")]
 		public string CountryCodeValue
		{
					get { return CountryCode.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude_tf")]
		public virtual INumberFieldWrapper Latitude
		{
			get { return GetField<NumberFieldWrapper>("Latitude", "latitude_tf"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude")]
 		public float LatitudeValue
		{
					get { return Latitude.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription_t")]
		public virtual ITextFieldWrapper LocationDescription
		{
			get { return GetField<TextFieldWrapper>("LocationDescription", "locationdescription_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription")]
 		public string LocationDescriptionValue
		{
					get { return LocationDescription.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude_tf")]
		public virtual INumberFieldWrapper Longitude
		{
			get { return GetField<NumberFieldWrapper>("Longitude", "longitude_tf"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude")]
 		public float LongitudeValue
		{
					get { return Longitude.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode_t")]
		public virtual ITextFieldWrapper ZipCode
		{
			get { return GetField<TextFieldWrapper>("ZipCode", "zipcode_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode")]
 		public string ZipCodeValue
		{
					get { return ZipCode.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
		public virtual ITextFieldWrapper Blob
		{
			get { return GetField<TextFieldWrapper>("Blob"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
 		public string BlobValue
		{
					get { return Blob.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path_t")]
		public virtual ITextFieldWrapper FilePath
		{
			get { return GetField<TextFieldWrapper>("File Path", "file_path_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path")]
 		public string FilePathValue
		{
					get { return FilePath.Value; }
				}
		/// <summary><para>Template: Pdf</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format_t")]
		public virtual ITextFieldWrapper Format
		{
			get { return GetField<TextFieldWrapper>("Format", "format_t"); }
		}

		/// <summary><para>Template: Pdf</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format")]
 		public string FormatValue
		{
					get { return Format.Value; }
				}
	
	}
}
#endregion
#region OoyalaLabel (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaLabel</para>
	/// <para>ID: {060621C8-6668-40D0-A578-53432121FEEF}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaLabel</para>
	/// </summary>
	[TemplateMapping("{060621C8-6668-40D0-A578-53432121FEEF}", "InterfaceMap")]
	public partial interface IOoyalaLabel : ICustomItemWrapper 	{		
    	/// <summary>
		/// <para>Template: OoyalaLabel</para><para>Field: FullName</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper FullName { get; }
 		string FullNameValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaLabel</para><para>Field: ID</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper ID { get; }
 		string IDValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaLabel</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name_t")]
		ITextFieldWrapper Name { get; }

    	/// <summary>
		/// <para>Template: OoyalaLabel</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name")]
 		string NameValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaLabel</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{060621C8-6668-40D0-A578-53432121FEEF}", typeof(Guid))]
	[TemplateMapping("{060621C8-6668-40D0-A578-53432121FEEF}", "")]
	public partial class OoyalaLabel : CustomItemWrapper, IOoyalaLabel
	{
		private Item _item = null;

		public OoyalaLabel(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaLabel(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaLabel(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaLabel(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaLabel</para><para>Field: FullName</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper FullName
		{
			get { return GetField<TextFieldWrapper>("FullName"); }
		}

		/// <summary><para>Template: OoyalaLabel</para><para>Field: FullName</para><para>Data type: ReadOnlyText</para></summary>
 		public string FullNameValue
		{
					get { return FullName.Value; }
				}
		/// <summary><para>Template: OoyalaLabel</para><para>Field: ID</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper ID
		{
			get { return GetField<TextFieldWrapper>("ID"); }
		}

		/// <summary><para>Template: OoyalaLabel</para><para>Field: ID</para><para>Data type: ReadOnlyText</para></summary>
 		public string IDValue
		{
					get { return ID.Value; }
				}
		/// <summary><para>Template: OoyalaLabel</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name_t")]
		public virtual ITextFieldWrapper Name
		{
			get { return GetField<TextFieldWrapper>("Name", "name_t"); }
		}

		/// <summary><para>Template: OoyalaLabel</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name")]
 		public string NameValue
		{
					get { return Name.Value; }
				}
	
	}
}
#endregion
#region OTT Device (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OTT Device</para>
	/// <para>ID: {08427D1C-5EC1-455C-B037-67A1C5752452}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Devices/OTT Device</para>
	/// </summary>
	[TemplateMapping("{08427D1C-5EC1-455C-B037-67A1C5752452}", "InterfaceMap")]
	public partial interface IOTTDevice : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IContentPage	{		
    	/// <summary>
		/// <para>Template: OTT Device</para><para>Field: DeviceLogo</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper DeviceLogo { get; }
 		string DeviceLogoValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Devices/OTT Device</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{08427D1C-5EC1-455C-B037-67A1C5752452}", typeof(Guid))]
	[TemplateMapping("{08427D1C-5EC1-455C-B037-67A1C5752452}", "")]
	public partial class OTTDevice : CustomItemWrapper, IOTTDevice
	{
		private Item _item = null;

		public OTTDevice(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OTTDevice(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OTTDevice(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OTTDevice(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OTT Device</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: OTT Device</para><para>Field: DeviceLogo</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper DeviceLogo
		{
			get { return GetField<ImageFieldWrapper>("Device Logo"); }
		}

		/// <summary><para>Template: OTT Device</para><para>Field: DeviceLogo</para><para>Data type: Image</para></summary>
 		public string DeviceLogoValue
		{
					get { return DeviceLogo.Value; }
				}
	
	}
}
#endregion
#region Executive List Rendering Parameters (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Executive List Rendering Parameters</para>
	/// <para>ID: {09AC4ACA-6265-4402-B650-7A23EF886F1E}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Executives/Rendering Parameters/Executive List Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{09AC4ACA-6265-4402-B650-7A23EF886F1E}", "InterfaceRenderingParameter")]
	public partial interface IExecutiveListRenderingParameters : IRenderingParameterWrapper , LM.Model.Templates.Ignite.IIgniteRenderingParameters	{		
    	/// <summary>
		/// <para>Template: Executive List Rendering Parameters</para><para>Field: HideFullBioLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper HideFullBioLabel { get; }
 		Guid HideFullBioLabelValue { get; }
    	/// <summary>
		/// <para>Template: Executive List Rendering Parameters</para><para>Field: ReadFullBioLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper ReadFullBioLabel { get; }
 		Guid ReadFullBioLabelValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Executives/Rendering Parameters/Executive List Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{09AC4ACA-6265-4402-B650-7A23EF886F1E}", typeof(Guid))]
	[TemplateMapping("{09AC4ACA-6265-4402-B650-7A23EF886F1E}", "RenderingParameter")]
	public partial class ExecutiveListRenderingParameters : RenderingParameterWrapper, IExecutiveListRenderingParameters
	{
		public ExecutiveListRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Executive List Rendering Parameters</para><para>Field: HideFullBioLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper HideFullBioLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Hide Full Bio Label", "droptree"); }
		}

		/// <summary><para>Template: Executive List Rendering Parameters</para><para>Field: HideFullBioLabel</para><para>Data type: Droptree</para></summary>
 		public Guid HideFullBioLabelValue
		{
					get { return HideFullBioLabel.Value; }
				}
		/// <summary><para>Template: Executive List Rendering Parameters</para><para>Field: ReadFullBioLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper ReadFullBioLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Read Full Bio Label", "droptree"); }
		}

		/// <summary><para>Template: Executive List Rendering Parameters</para><para>Field: ReadFullBioLabel</para><para>Data type: Droptree</para></summary>
 		public Guid ReadFullBioLabelValue
		{
					get { return ReadFullBioLabel.Value; }
				}
	
	}
}
#endregion
#region Contact List Rendering Parameters (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contact List Rendering Parameters</para>
	/// <para>ID: {0A0E1698-EE32-490E-B248-59676C02B463}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Rendering Parameters/Contact List Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{0A0E1698-EE32-490E-B248-59676C02B463}", "InterfaceRenderingParameter")]
	public partial interface IContactListRenderingParameters : IRenderingParameterWrapper , LM.Model.Templates.Ignite.IIgniteRenderingParameters	{		
    	/// <summary>
		/// <para>Template: Contact List Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper TitleText { get; }
 		Guid TitleTextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Rendering Parameters/Contact List Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0A0E1698-EE32-490E-B248-59676C02B463}", typeof(Guid))]
	[TemplateMapping("{0A0E1698-EE32-490E-B248-59676C02B463}", "RenderingParameter")]
	public partial class ContactListRenderingParameters : RenderingParameterWrapper, IContactListRenderingParameters
	{
		public ContactListRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Contact List Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper TitleText
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Title Text", "droptree"); }
		}

		/// <summary><para>Template: Contact List Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para></summary>
 		public Guid TitleTextValue
		{
					get { return TitleText.Value; }
				}
	
	}
}
#endregion
#region Contest Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contest Page</para>
	/// <para>ID: {0B0CC955-6422-46BF-8030-89B52148D10C}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Contests/Page Types/Contest Page</para>
	/// </summary>
	[TemplateMapping("{0B0CC955-6422-46BF-8030-89B52148D10C}", "InterfaceMap")]
	public partial interface IContestPage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IContest, LM.Model.Templates.PokerCentral.ISponsoredContentPage	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Contests/Page Types/Contest Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0B0CC955-6422-46BF-8030-89B52148D10C}", typeof(Guid))]
	[TemplateMapping("{0B0CC955-6422-46BF-8030-89B52148D10C}", "")]
	public partial class ContestPage : CustomItemWrapper, IContestPage
	{
		private Item _item = null;

		public ContestPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContestPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContestPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContestPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Contest Page</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contest_header_t")]
		public virtual ITextFieldWrapper ContestHeader
		{
			get { return GetField<TextFieldWrapper>("Contest Header", "contest_header_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: ContestHeader</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contest_header")]
 		public string ContestHeaderValue
		{
					get { return ContestHeader.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: ContestImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContestImage
		{
			get { return GetField<ImageFieldWrapper>("Contest Image"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: ContestImage</para><para>Data type: Image</para></summary>
 		public string ContestImageValue
		{
					get { return ContestImage.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("contest_video_sm")]
		public virtual IListFieldWrapper ContestVideo
		{
			get { return GetField<ListFieldWrapper>("Contest Video", "contest_video_sm"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: ContestVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("contest_video")]
 		public IEnumerable<Guid> ContestVideoValue
		{
					get { return ContestVideo.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: Context</para><para>Data type: Droptree</para></summary>
		[IndexField("context_s")]
		public virtual ILinkFieldWrapper Context
		{
			get { return GetField<LinkFieldWrapper>("Context", "context_s"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: Context</para><para>Data type: Droptree</para></summary>
		[IndexField("context")]
 		public Guid ContextValue
		{
					get { return Context.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: Contest Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Contest Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region Home Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Home Page</para>
	/// <para>ID: {0C4BBB1E-5B0F-41AA-B5A0-E3226076C676}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Page Types/Home Page</para>
	/// </summary>
	[TemplateMapping("{0C4BBB1E-5B0F-41AA-B5A0-E3226076C676}", "InterfaceMap")]
	public partial interface IHomePage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IContentPage	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Page Types/Home Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0C4BBB1E-5B0F-41AA-B5A0-E3226076C676}", typeof(Guid))]
	[TemplateMapping("{0C4BBB1E-5B0F-41AA-B5A0-E3226076C676}", "")]
	public partial class HomePage : CustomItemWrapper, IHomePage
	{
		private Item _item = null;

		public HomePage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public HomePage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public HomePage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public HomePage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Home Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Home Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Home Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
	
	}
}
#endregion
#region Social Media Link (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Social Media Link</para>
	/// <para>ID: {153A097D-4C65-4A7F-9302-A8318EB89857}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Social Media/Social Media Link</para>
	/// </summary>
	[TemplateMapping("{153A097D-4C65-4A7F-9302-A8318EB89857}", "InterfaceMap")]
	public partial interface ISocialMediaLink : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Social Media Link</para><para>Field: LinkUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("link_url_t")]
		IGeneralLinkFieldWrapper LinkUrl { get; }

    	/// <summary>
		/// <para>Template: Social Media Link</para><para>Field: LinkUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("link_url")]
 		string LinkUrlValue { get; }
    	/// <summary>
		/// <para>Template: Social Media Link</para><para>Field: SpriteId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("sprite_id_t")]
		ITextFieldWrapper SpriteId { get; }

    	/// <summary>
		/// <para>Template: Social Media Link</para><para>Field: SpriteId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("sprite_id")]
 		string SpriteIdValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Social Media/Social Media Link</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{153A097D-4C65-4A7F-9302-A8318EB89857}", typeof(Guid))]
	[TemplateMapping("{153A097D-4C65-4A7F-9302-A8318EB89857}", "")]
	public partial class SocialMediaLink : CustomItemWrapper, ISocialMediaLink
	{
		private Item _item = null;

		public SocialMediaLink(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SocialMediaLink(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SocialMediaLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SocialMediaLink(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Social Media Link</para><para>Field: LinkUrl</para><para>Data type: General Link</para></summary>
		[IndexField("link_url_t")]
		public virtual IGeneralLinkFieldWrapper LinkUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Link Url", "link_url_t"); }
		}

		/// <summary><para>Template: Social Media Link</para><para>Field: LinkUrl</para><para>Data type: General Link</para></summary>
		[IndexField("link_url")]
 		public string LinkUrlValue
		{
					get { return LinkUrl.Value; }
				}
		/// <summary><para>Template: Social Media Link</para><para>Field: SpriteId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sprite_id_t")]
		public virtual ITextFieldWrapper SpriteId
		{
			get { return GetField<TextFieldWrapper>("Sprite Id", "sprite_id_t"); }
		}

		/// <summary><para>Template: Social Media Link</para><para>Field: SpriteId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sprite_id")]
 		public string SpriteIdValue
		{
					get { return SpriteId.Value; }
				}
	
	}
}
#endregion
#region Featured Silder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Featured Silder</para>
	/// <para>ID: {16469485-E00C-4470-A458-931D92E0552E}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Featured Silder</para>
	/// </summary>
	[TemplateMapping("{16469485-E00C-4470-A458-931D92E0552E}", "InterfaceMap")]
	public partial interface IFeaturedSilder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Featured Silder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{16469485-E00C-4470-A458-931D92E0552E}", typeof(Guid))]
	[TemplateMapping("{16469485-E00C-4470-A458-931D92E0552E}", "")]
	public partial class FeaturedSilder : CustomItemWrapper, IFeaturedSilder
	{
		private Item _item = null;

		public FeaturedSilder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public FeaturedSilder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public FeaturedSilder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public FeaturedSilder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Site Root (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Site Root</para>
	/// <para>ID: {16C0EF20-4B23-4201-B57D-F8A60BADC17B}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Site Root</para>
	/// </summary>
	[TemplateMapping("{16C0EF20-4B23-4201-B57D-F8A60BADC17B}", "InterfaceMap")]
	public partial interface ISiteRoot : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SiteBackgroundImage</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper SiteBackgroundImage { get; }
 		string SiteBackgroundImageValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SiteLogo</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper SiteLogo { get; }
 		string SiteLogoValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SiteTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("site_title_t")]
		ITextFieldWrapper SiteTitle { get; }

    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SiteTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("site_title")]
 		string SiteTitleValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaFacebookAppId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_facebook_app_id_t")]
		ITextFieldWrapper MetaFacebookAppId { get; }

    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaFacebookAppId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_facebook_app_id")]
 		string MetaFacebookAppIdValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaSiteTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_site_title_t")]
		ITextFieldWrapper MetaSiteTitle { get; }

    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaSiteTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_site_title")]
 		string MetaSiteTitleValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaTwitterAccount</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_twitter_account_t")]
		ITextFieldWrapper MetaTwitterAccount { get; }

    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: MetaTwitterAccount</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_twitter_account")]
 		string MetaTwitterAccountValue { get; }
    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SettingsFolder</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("settings_folder_s")]
		ILinkFieldWrapper SettingsFolder { get; }

    	/// <summary>
		/// <para>Template: Site Root</para><para>Field: SettingsFolder</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("settings_folder")]
 		Guid SettingsFolderValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Site Root</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{16C0EF20-4B23-4201-B57D-F8A60BADC17B}", typeof(Guid))]
	[TemplateMapping("{16C0EF20-4B23-4201-B57D-F8A60BADC17B}", "")]
	public partial class SiteRoot : CustomItemWrapper, ISiteRoot
	{
		private Item _item = null;

		public SiteRoot(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteRoot(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteRoot(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteRoot(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Site Root</para><para>Field: SiteBackgroundImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SiteBackgroundImage
		{
			get { return GetField<ImageFieldWrapper>("Site Background Image"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: SiteBackgroundImage</para><para>Data type: Image</para></summary>
 		public string SiteBackgroundImageValue
		{
					get { return SiteBackgroundImage.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: SiteLogo</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SiteLogo
		{
			get { return GetField<ImageFieldWrapper>("Site Logo"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: SiteLogo</para><para>Data type: Image</para></summary>
 		public string SiteLogoValue
		{
					get { return SiteLogo.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: SiteTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("site_title_t")]
		public virtual ITextFieldWrapper SiteTitle
		{
			get { return GetField<TextFieldWrapper>("Site Title", "site_title_t"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: SiteTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("site_title")]
 		public string SiteTitleValue
		{
					get { return SiteTitle.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: MetaFacebookAppId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_facebook_app_id_t")]
		public virtual ITextFieldWrapper MetaFacebookAppId
		{
			get { return GetField<TextFieldWrapper>("Meta Facebook App Id", "meta_facebook_app_id_t"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: MetaFacebookAppId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_facebook_app_id")]
 		public string MetaFacebookAppIdValue
		{
					get { return MetaFacebookAppId.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: MetaSiteTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_site_title_t")]
		public virtual ITextFieldWrapper MetaSiteTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Site Title", "meta_site_title_t"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: MetaSiteTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_site_title")]
 		public string MetaSiteTitleValue
		{
					get { return MetaSiteTitle.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: MetaTwitterAccount</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_twitter_account_t")]
		public virtual ITextFieldWrapper MetaTwitterAccount
		{
			get { return GetField<TextFieldWrapper>("Meta Twitter Account", "meta_twitter_account_t"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: MetaTwitterAccount</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_twitter_account")]
 		public string MetaTwitterAccountValue
		{
					get { return MetaTwitterAccount.Value; }
				}
		/// <summary><para>Template: Site Root</para><para>Field: SettingsFolder</para><para>Data type: Droptree</para></summary>
		[IndexField("settings_folder_s")]
		public virtual ILinkFieldWrapper SettingsFolder
		{
			get { return GetField<LinkFieldWrapper>("Settings Folder", "settings_folder_s"); }
		}

		/// <summary><para>Template: Site Root</para><para>Field: SettingsFolder</para><para>Data type: Droptree</para></summary>
		[IndexField("settings_folder")]
 		public Guid SettingsFolderValue
		{
					get { return SettingsFolder.Value; }
				}
	
	}
}
#endregion
#region Download Link (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Download Link</para>
	/// <para>ID: {1C2FD68F-CBFA-4A1D-8AE4-F762D0F1C489}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Download Link</para>
	/// </summary>
	[TemplateMapping("{1C2FD68F-CBFA-4A1D-8AE4-F762D0F1C489}", "InterfaceMap")]
	public partial interface IDownloadLink : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IAnalyticsTracking	{		
    	/// <summary>
		/// <para>Template: Download Link</para><para>Field: LinkFile</para><para>Data type: File</para>
        /// </summary>
		IFileFieldWrapper LinkFile { get; }
 		string LinkFileValue { get; }
    	/// <summary>
		/// <para>Template: Download Link</para><para>Field: LinkText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("link_text_t")]
		ITextFieldWrapper LinkText { get; }

    	/// <summary>
		/// <para>Template: Download Link</para><para>Field: LinkText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("link_text")]
 		string LinkTextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Download Link</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{1C2FD68F-CBFA-4A1D-8AE4-F762D0F1C489}", typeof(Guid))]
	[TemplateMapping("{1C2FD68F-CBFA-4A1D-8AE4-F762D0F1C489}", "")]
	public partial class DownloadLink : CustomItemWrapper, IDownloadLink
	{
		private Item _item = null;

		public DownloadLink(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public DownloadLink(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public DownloadLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public DownloadLink(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Download Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Download Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Download Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Download Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Download Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Download Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Download Link</para><para>Field: LinkFile</para><para>Data type: File</para></summary>
		public virtual IFileFieldWrapper LinkFile
		{
			get { return GetField<FileFieldWrapper>("Link File"); }
		}

		/// <summary><para>Template: Download Link</para><para>Field: LinkFile</para><para>Data type: File</para></summary>
 		public string LinkFileValue
		{
					get { return LinkFile.Value; }
				}
		/// <summary><para>Template: Download Link</para><para>Field: LinkText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("link_text_t")]
		public virtual ITextFieldWrapper LinkText
		{
			get { return GetField<TextFieldWrapper>("Link Text", "link_text_t"); }
		}

		/// <summary><para>Template: Download Link</para><para>Field: LinkText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("link_text")]
 		public string LinkTextValue
		{
					get { return LinkText.Value; }
				}
	
	}
}
#endregion
#region Assets (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Assets</para>
	/// <para>ID: {1F443C63-BBC5-40F3-AEE2-A7A70EA48F0D}</para>
	/// <para>/sitecore/templates/Ignite/Assets</para>
	/// </summary>
	[TemplateMapping("{1F443C63-BBC5-40F3-AEE2-A7A70EA48F0D}", "InterfaceMap")]
	public partial interface IAssets : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Assets</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{1F443C63-BBC5-40F3-AEE2-A7A70EA48F0D}", typeof(Guid))]
	[TemplateMapping("{1F443C63-BBC5-40F3-AEE2-A7A70EA48F0D}", "")]
	public partial class Assets : CustomItemWrapper, IAssets
	{
		private Item _item = null;

		public Assets(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Assets(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Assets(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Assets(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Base Settings (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Base Settings</para>
	/// <para>ID: {234669E7-1942-4681-B327-A0814A544BB1}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Base Settings</para>
	/// </summary>
	[TemplateMapping("{234669E7-1942-4681-B327-A0814A544BB1}", "InterfaceMap")]
	public partial interface IBaseSettings : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Base Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{234669E7-1942-4681-B327-A0814A544BB1}", typeof(Guid))]
	[TemplateMapping("{234669E7-1942-4681-B327-A0814A544BB1}", "")]
	public partial class BaseSettings : CustomItemWrapper, IBaseSettings
	{
		private Item _item = null;

		public BaseSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BaseSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BaseSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BaseSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Lookup Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Lookup Folder</para>
	/// <para>ID: {2A757A67-4F93-4D03-8C63-18EB2E9C194A}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Lookup Folder</para>
	/// </summary>
	[TemplateMapping("{2A757A67-4F93-4D03-8C63-18EB2E9C194A}", "InterfaceMap")]
	public partial interface ILookupFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Lookup Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2A757A67-4F93-4D03-8C63-18EB2E9C194A}", typeof(Guid))]
	[TemplateMapping("{2A757A67-4F93-4D03-8C63-18EB2E9C194A}", "")]
	public partial class LookupFolder : CustomItemWrapper, ILookupFolder
	{
		private Item _item = null;

		public LookupFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public LookupFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public LookupFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public LookupFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Video Slide (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Video Slide</para>
	/// <para>ID: {2B677748-027F-4012-A817-C1034BF3F5E1}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Video Slide</para>
	/// </summary>
	[TemplateMapping("{2B677748-027F-4012-A817-C1034BF3F5E1}", "InterfaceMap")]
	public partial interface IVideoSlide : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSlide	{		
    	/// <summary>
		/// <para>Template: Video Slide</para><para>Field: CTAVideo</para><para>Data type: Multilist with Search</para>
        /// </summary>
		[IndexField("cta_video_sm")]
		IListFieldWrapper CTAVideo { get; }

    	/// <summary>
		/// <para>Template: Video Slide</para><para>Field: CTAVideo</para><para>Data type: Multilist with Search</para>
        /// </summary>
		[IndexField("cta_video")]
 		IEnumerable<Guid> CTAVideoValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Video Slide</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2B677748-027F-4012-A817-C1034BF3F5E1}", typeof(Guid))]
	[TemplateMapping("{2B677748-027F-4012-A817-C1034BF3F5E1}", "")]
	public partial class VideoSlide : CustomItemWrapper, IVideoSlide
	{
		private Item _item = null;

		public VideoSlide(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public VideoSlide(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public VideoSlide(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public VideoSlide(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Video Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
		/// <summary><para>Template: Video Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImageMobile
		{
			get { return GetField<ImageFieldWrapper>("Background Image Mobile"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
 		public string BackgroundImageMobileValue
		{
					get { return BackgroundImageMobile.Value; }
				}
		/// <summary><para>Template: Video Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImage
		{
			get { return GetField<ImageFieldWrapper>("Background Image"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
 		public string BackgroundImageValue
		{
					get { return BackgroundImage.Value; }
				}
		/// <summary><para>Template: Video Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description_t")]
		public virtual ITextFieldWrapper SlideDescription
		{
			get { return GetField<TextFieldWrapper>("Slide Description", "slide_description_t"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description")]
 		public string SlideDescriptionValue
		{
					get { return SlideDescription.Value; }
				}
		/// <summary><para>Template: Video Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title_t")]
		public virtual ITextFieldWrapper SlideTitle
		{
			get { return GetField<TextFieldWrapper>("Slide Title", "slide_title_t"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title")]
 		public string SlideTitleValue
		{
					get { return SlideTitle.Value; }
				}
		/// <summary><para>Template: Video Slide</para><para>Field: CTAVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("cta_video_sm")]
		public virtual IListFieldWrapper CTAVideo
		{
			get { return GetField<ListFieldWrapper>("CTA Video", "cta_video_sm"); }
		}

		/// <summary><para>Template: Video Slide</para><para>Field: CTAVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("cta_video")]
 		public IEnumerable<Guid> CTAVideoValue
		{
					get { return CTAVideo.Value; }
				}
	
	}
}
#endregion
#region Navigation (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Navigation</para>
	/// <para>ID: {2D6B1753-B66E-442A-A34A-C6C7A0D21EC4}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Navigation</para>
	/// </summary>
	[TemplateMapping("{2D6B1753-B66E-442A-A34A-C6C7A0D21EC4}", "InterfaceMap")]
	public partial interface INavigation : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IAnalyticsTracking	{		
    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_menu_b")]
		IBooleanFieldWrapper HideFromMenu { get; }

    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_menu")]
 		bool HideFromMenuValue { get; }
    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("navigation_title_t")]
		ITextFieldWrapper NavigationTitle { get; }

    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("navigation_title")]
 		string NavigationTitleValue { get; }
    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("navigation_url_t")]
		IGeneralLinkFieldWrapper NavigationUrl { get; }

    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("navigation_url")]
 		string NavigationUrlValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Navigation</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2D6B1753-B66E-442A-A34A-C6C7A0D21EC4}", typeof(Guid))]
	[TemplateMapping("{2D6B1753-B66E-442A-A34A-C6C7A0D21EC4}", "")]
	public partial class Navigation : CustomItemWrapper, INavigation
	{
		private Item _item = null;

		public Navigation(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Navigation(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Navigation(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Navigation(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Navigation</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Navigation</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Navigation</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Navigation</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
	
	}
}
#endregion
#region OoyalaMediaElement (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaMediaElement</para>
	/// <para>ID: {2F28989C-5028-472C-89AF-73E4E8BF1A93}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaMediaElement</para>
	/// </summary>
	[TemplateMapping("{2F28989C-5028-472C-89AF-73E4E8BF1A93}", "InterfaceMap")]
	public partial interface IOoyalaMediaElement : ICustomItemWrapper 	{		
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para>
        /// </summary>
		ITextFieldWrapper CustomMetadata { get; }
 		string CustomMetadataValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper AssetType { get; }
 		string AssetTypeValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Description</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("description_t")]
		IRichTextFieldWrapper Description { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Description</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("description")]
 		string DescriptionValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper Duration { get; }
 		string DurationValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper EmbedCode { get; }
 		string EmbedCodeValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("islivestream_b")]
		IBooleanFieldWrapper IsLiveStream { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("islivestream")]
 		bool IsLiveStreamValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name_t")]
		ITextFieldWrapper Name { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name")]
 		string NameValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Player</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("player_s")]
		ILinkFieldWrapper Player { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Player</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("player")]
 		Guid PlayerValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para>
        /// </summary>
		ITextFieldWrapper PreviewImageUrl { get; }
 		string PreviewImageUrlValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Status</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("status_t")]
		ITextFieldWrapper Status { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: Status</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("status")]
 		string StatusValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper CreatedAt { get; }
 		string CreatedAtValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper UpdatedAt { get; }
 		string UpdatedAtValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: LabelsList</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("labelslist_sm")]
		IListFieldWrapper LabelsList { get; }

    	/// <summary>
		/// <para>Template: OoyalaMediaElement</para><para>Field: LabelsList</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("labelslist")]
 		IEnumerable<Guid> LabelsListValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaMediaElement</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2F28989C-5028-472C-89AF-73E4E8BF1A93}", typeof(Guid))]
	[TemplateMapping("{2F28989C-5028-472C-89AF-73E4E8BF1A93}", "")]
	public partial class OoyalaMediaElement : CustomItemWrapper, IOoyalaMediaElement
	{
		private Item _item = null;

		public OoyalaMediaElement(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaMediaElement(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaMediaElement(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaMediaElement(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
		public virtual ITextFieldWrapper CustomMetadata
		{
			get { return GetField<TextFieldWrapper>("CustomMetadata"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
 		public string CustomMetadataValue
		{
					get { return CustomMetadata.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper AssetType
		{
			get { return GetField<TextFieldWrapper>("AssetType"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
 		public string AssetTypeValue
		{
					get { return AssetType.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description_t")]
		public virtual IRichTextFieldWrapper Description
		{
			get { return GetField<RichTextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper Duration
		{
			get { return GetField<TextFieldWrapper>("Duration"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
 		public string DurationValue
		{
					get { return Duration.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper EmbedCode
		{
			get { return GetField<TextFieldWrapper>("EmbedCode"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
 		public string EmbedCodeValue
		{
					get { return EmbedCode.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream_b")]
		public virtual IBooleanFieldWrapper IsLiveStream
		{
			get { return GetField<BooleanFieldWrapper>("isLiveStream", "islivestream_b"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream")]
 		public bool IsLiveStreamValue
		{
					get { return IsLiveStream.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name_t")]
		public virtual ITextFieldWrapper Name
		{
			get { return GetField<TextFieldWrapper>("Name", "name_t"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name")]
 		public string NameValue
		{
					get { return Name.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player_s")]
		public virtual ILinkFieldWrapper Player
		{
			get { return GetField<LinkFieldWrapper>("Player", "player_s"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player")]
 		public Guid PlayerValue
		{
					get { return Player.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
		public virtual ITextFieldWrapper PreviewImageUrl
		{
			get { return GetField<TextFieldWrapper>("PreviewImageUrl"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
 		public string PreviewImageUrlValue
		{
					get { return PreviewImageUrl.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status_t")]
		public virtual ITextFieldWrapper Status
		{
			get { return GetField<TextFieldWrapper>("Status", "status_t"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status")]
 		public string StatusValue
		{
					get { return Status.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper CreatedAt
		{
			get { return GetField<TextFieldWrapper>("CreatedAt"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string CreatedAtValue
		{
					get { return CreatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper UpdatedAt
		{
			get { return GetField<TextFieldWrapper>("UpdatedAt"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string UpdatedAtValue
		{
					get { return UpdatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist_sm")]
		public virtual IListFieldWrapper LabelsList
		{
			get { return GetField<ListFieldWrapper>("LabelsList", "labelslist_sm"); }
		}

		/// <summary><para>Template: OoyalaMediaElement</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist")]
 		public IEnumerable<Guid> LabelsListValue
		{
					get { return LabelsList.Value; }
				}
	
	}
}
#endregion
#region Contact (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contact</para>
	/// <para>ID: {2FF0C7E4-0861-4B3B-8B28-5EF49009293A}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Contact</para>
	/// </summary>
	[TemplateMapping("{2FF0C7E4-0861-4B3B-8B28-5EF49009293A}", "InterfaceMap")]
	public partial interface IContact : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactEmail</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_email_t")]
		ITextFieldWrapper ContactEmail { get; }

    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactEmail</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_email")]
 		string ContactEmailValue { get; }
    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactGroup</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_group_t")]
		ITextFieldWrapper ContactGroup { get; }

    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactGroup</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_group")]
 		string ContactGroupValue { get; }
    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_name_t")]
		ITextFieldWrapper ContactName { get; }

    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_name")]
 		string ContactNameValue { get; }
    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactTelephoneNumber</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_telephone_number_t")]
		ITextFieldWrapper ContactTelephoneNumber { get; }

    	/// <summary>
		/// <para>Template: Contact</para><para>Field: ContactTelephoneNumber</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("contact_telephone_number")]
 		string ContactTelephoneNumberValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Contact</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2FF0C7E4-0861-4B3B-8B28-5EF49009293A}", typeof(Guid))]
	[TemplateMapping("{2FF0C7E4-0861-4B3B-8B28-5EF49009293A}", "")]
	public partial class Contact : CustomItemWrapper, IContact
	{
		private Item _item = null;

		public Contact(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Contact(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Contact(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Contact(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Contact</para><para>Field: ContactEmail</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_email_t")]
		public virtual ITextFieldWrapper ContactEmail
		{
			get { return GetField<TextFieldWrapper>("Contact Email", "contact_email_t"); }
		}

		/// <summary><para>Template: Contact</para><para>Field: ContactEmail</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_email")]
 		public string ContactEmailValue
		{
					get { return ContactEmail.Value; }
				}
		/// <summary><para>Template: Contact</para><para>Field: ContactGroup</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_group_t")]
		public virtual ITextFieldWrapper ContactGroup
		{
			get { return GetField<TextFieldWrapper>("Contact Group", "contact_group_t"); }
		}

		/// <summary><para>Template: Contact</para><para>Field: ContactGroup</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_group")]
 		public string ContactGroupValue
		{
					get { return ContactGroup.Value; }
				}
		/// <summary><para>Template: Contact</para><para>Field: ContactName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_name_t")]
		public virtual ITextFieldWrapper ContactName
		{
			get { return GetField<TextFieldWrapper>("Contact Name", "contact_name_t"); }
		}

		/// <summary><para>Template: Contact</para><para>Field: ContactName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_name")]
 		public string ContactNameValue
		{
					get { return ContactName.Value; }
				}
		/// <summary><para>Template: Contact</para><para>Field: ContactTelephoneNumber</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_telephone_number_t")]
		public virtual ITextFieldWrapper ContactTelephoneNumber
		{
			get { return GetField<TextFieldWrapper>("Contact Telephone Number", "contact_telephone_number_t"); }
		}

		/// <summary><para>Template: Contact</para><para>Field: ContactTelephoneNumber</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("contact_telephone_number")]
 		public string ContactTelephoneNumberValue
		{
					get { return ContactTelephoneNumber.Value; }
				}
	
	}
}
#endregion
#region Internal Link Slide (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Internal Link Slide</para>
	/// <para>ID: {33360066-FE38-47DC-ACDD-A3688E67E285}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Internal Link Slide</para>
	/// </summary>
	[TemplateMapping("{33360066-FE38-47DC-ACDD-A3688E67E285}", "InterfaceMap")]
	public partial interface IInternalLinkSlide : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSlide	{		
    	/// <summary>
		/// <para>Template: Internal Link Slide</para><para>Field: CTALink</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("cta_link_t")]
		IGeneralLinkFieldWrapper CTALink { get; }

    	/// <summary>
		/// <para>Template: Internal Link Slide</para><para>Field: CTALink</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("cta_link")]
 		string CTALinkValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Internal Link Slide</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{33360066-FE38-47DC-ACDD-A3688E67E285}", typeof(Guid))]
	[TemplateMapping("{33360066-FE38-47DC-ACDD-A3688E67E285}", "")]
	public partial class InternalLinkSlide : CustomItemWrapper, IInternalLinkSlide
	{
		private Item _item = null;

		public InternalLinkSlide(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public InternalLinkSlide(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public InternalLinkSlide(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public InternalLinkSlide(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
		/// <summary><para>Template: Internal Link Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImageMobile
		{
			get { return GetField<ImageFieldWrapper>("Background Image Mobile"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
 		public string BackgroundImageMobileValue
		{
					get { return BackgroundImageMobile.Value; }
				}
		/// <summary><para>Template: Internal Link Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImage
		{
			get { return GetField<ImageFieldWrapper>("Background Image"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
 		public string BackgroundImageValue
		{
					get { return BackgroundImage.Value; }
				}
		/// <summary><para>Template: Internal Link Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description_t")]
		public virtual ITextFieldWrapper SlideDescription
		{
			get { return GetField<TextFieldWrapper>("Slide Description", "slide_description_t"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description")]
 		public string SlideDescriptionValue
		{
					get { return SlideDescription.Value; }
				}
		/// <summary><para>Template: Internal Link Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title_t")]
		public virtual ITextFieldWrapper SlideTitle
		{
			get { return GetField<TextFieldWrapper>("Slide Title", "slide_title_t"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title")]
 		public string SlideTitleValue
		{
					get { return SlideTitle.Value; }
				}
		/// <summary><para>Template: Internal Link Slide</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link_t")]
		public virtual IGeneralLinkFieldWrapper CTALink
		{
			get { return GetField<GeneralLinkFieldWrapper>("CTA Link", "cta_link_t"); }
		}

		/// <summary><para>Template: Internal Link Slide</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link")]
 		public string CTALinkValue
		{
					get { return CTALink.Value; }
				}
	
	}
}
#endregion
#region Social Media Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Social Media Folder</para>
	/// <para>ID: {43E53022-FDFE-4E77-90AE-F11176F6DAF3}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Social Media/Social Media Folder</para>
	/// </summary>
	[TemplateMapping("{43E53022-FDFE-4E77-90AE-F11176F6DAF3}", "InterfaceMap")]
	public partial interface ISocialMediaFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Social Media/Social Media Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{43E53022-FDFE-4E77-90AE-F11176F6DAF3}", typeof(Guid))]
	[TemplateMapping("{43E53022-FDFE-4E77-90AE-F11176F6DAF3}", "")]
	public partial class SocialMediaFolder : CustomItemWrapper, ISocialMediaFolder
	{
		private Item _item = null;

		public SocialMediaFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SocialMediaFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SocialMediaFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SocialMediaFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region OoyalaChannel (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaChannel</para>
	/// <para>ID: {49731DEB-A021-448F-ABC2-B9238D5A7E05}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaChannel</para>
	/// </summary>
	[TemplateMapping("{49731DEB-A021-448F-ABC2-B9238D5A7E05}", "InterfaceMap")]
	public partial interface IOoyalaChannel : ICustomItemWrapper , LM.Model.Templates.Ignite.IOoyalaMediaElement	{		
    	/// <summary>
		/// <para>Template: OoyalaChannel</para><para>Field: VideoList</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("videolist_sm")]
		IListFieldWrapper VideoList { get; }

    	/// <summary>
		/// <para>Template: OoyalaChannel</para><para>Field: VideoList</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("videolist")]
 		IEnumerable<Guid> VideoListValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaChannel</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{49731DEB-A021-448F-ABC2-B9238D5A7E05}", typeof(Guid))]
	[TemplateMapping("{49731DEB-A021-448F-ABC2-B9238D5A7E05}", "")]
	public partial class OoyalaChannel : CustomItemWrapper, IOoyalaChannel
	{
		private Item _item = null;

		public OoyalaChannel(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaChannel(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaChannel(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaChannel(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
		public virtual ITextFieldWrapper CustomMetadata
		{
			get { return GetField<TextFieldWrapper>("CustomMetadata"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
 		public string CustomMetadataValue
		{
					get { return CustomMetadata.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper AssetType
		{
			get { return GetField<TextFieldWrapper>("AssetType"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
 		public string AssetTypeValue
		{
					get { return AssetType.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description_t")]
		public virtual IRichTextFieldWrapper Description
		{
			get { return GetField<RichTextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper Duration
		{
			get { return GetField<TextFieldWrapper>("Duration"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
 		public string DurationValue
		{
					get { return Duration.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper EmbedCode
		{
			get { return GetField<TextFieldWrapper>("EmbedCode"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
 		public string EmbedCodeValue
		{
					get { return EmbedCode.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream_b")]
		public virtual IBooleanFieldWrapper IsLiveStream
		{
			get { return GetField<BooleanFieldWrapper>("isLiveStream", "islivestream_b"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream")]
 		public bool IsLiveStreamValue
		{
					get { return IsLiveStream.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name_t")]
		public virtual ITextFieldWrapper Name
		{
			get { return GetField<TextFieldWrapper>("Name", "name_t"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name")]
 		public string NameValue
		{
					get { return Name.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player_s")]
		public virtual ILinkFieldWrapper Player
		{
			get { return GetField<LinkFieldWrapper>("Player", "player_s"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player")]
 		public Guid PlayerValue
		{
					get { return Player.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
		public virtual ITextFieldWrapper PreviewImageUrl
		{
			get { return GetField<TextFieldWrapper>("PreviewImageUrl"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
 		public string PreviewImageUrlValue
		{
					get { return PreviewImageUrl.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status_t")]
		public virtual ITextFieldWrapper Status
		{
			get { return GetField<TextFieldWrapper>("Status", "status_t"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status")]
 		public string StatusValue
		{
					get { return Status.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper CreatedAt
		{
			get { return GetField<TextFieldWrapper>("CreatedAt"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string CreatedAtValue
		{
					get { return CreatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper UpdatedAt
		{
			get { return GetField<TextFieldWrapper>("UpdatedAt"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string UpdatedAtValue
		{
					get { return UpdatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist_sm")]
		public virtual IListFieldWrapper LabelsList
		{
			get { return GetField<ListFieldWrapper>("LabelsList", "labelslist_sm"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist")]
 		public IEnumerable<Guid> LabelsListValue
		{
					get { return LabelsList.Value; }
				}
		/// <summary><para>Template: OoyalaChannel</para><para>Field: VideoList</para><para>Data type: Multilist</para></summary>
		[IndexField("videolist_sm")]
		public virtual IListFieldWrapper VideoList
		{
			get { return GetField<ListFieldWrapper>("VideoList", "videolist_sm"); }
		}

		/// <summary><para>Template: OoyalaChannel</para><para>Field: VideoList</para><para>Data type: Multilist</para></summary>
		[IndexField("videolist")]
 		public IEnumerable<Guid> VideoListValue
		{
					get { return VideoList.Value; }
				}
	
	}
}
#endregion
#region HtmlPhrase (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: HtmlPhrase</para>
	/// <para>ID: {4AD20F42-1A7D-4973-96F9-DC37152D07DA}</para>
	/// <para>/sitecore/templates/Ignite/Phrases/HtmlPhrase</para>
	/// </summary>
	[TemplateMapping("{4AD20F42-1A7D-4973-96F9-DC37152D07DA}", "InterfaceMap")]
	public partial interface IHtmlPhrase : ICustomItemWrapper , LM.Model.Templates.Ignite.IPhrase	{		
    	/// <summary>
		/// <para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("phrase_t")]
		IRichTextFieldWrapper Phrase { get; }

    	/// <summary>
		/// <para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("phrase")]
 		string PhraseValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Phrases/HtmlPhrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4AD20F42-1A7D-4973-96F9-DC37152D07DA}", typeof(Guid))]
	[TemplateMapping("{4AD20F42-1A7D-4973-96F9-DC37152D07DA}", "")]
	public partial class HtmlPhrase : CustomItemWrapper, IHtmlPhrase
	{
		private Item _item = null;

		public HtmlPhrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public HtmlPhrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public HtmlPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public HtmlPhrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase_t")]
		public virtual IRichTextFieldWrapper Phrase
		{
			get { return GetField<RichTextFieldWrapper>("Phrase", "phrase_t"); }
		}

		/// <summary><para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase")]
 		public string PhraseValue
		{
					get { return Phrase.Value; }
				}
	
	}
}
#endregion
#region Image CTA (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Image CTA</para>
	/// <para>ID: {4DFB45D4-7AB7-4A74-803D-C00917E65219}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Image CTA</para>
	/// </summary>
	[TemplateMapping("{4DFB45D4-7AB7-4A74-803D-C00917E65219}", "InterfaceMap")]
	public partial interface IImageCTA : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseCTA	{		
    	/// <summary>
		/// <para>Template: Image CTA</para><para>Field: CTAImage</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper CTAImage { get; }
 		string CTAImageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Image CTA</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4DFB45D4-7AB7-4A74-803D-C00917E65219}", typeof(Guid))]
	[TemplateMapping("{4DFB45D4-7AB7-4A74-803D-C00917E65219}", "")]
	public partial class ImageCTA : CustomItemWrapper, IImageCTA
	{
		private Item _item = null;

		public ImageCTA(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ImageCTA(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ImageCTA(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ImageCTA(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Image CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link_t")]
		public virtual IGeneralLinkFieldWrapper CTALink
		{
			get { return GetField<GeneralLinkFieldWrapper>("CTA Link", "cta_link_t"); }
		}

		/// <summary><para>Template: Image CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link")]
 		public string CTALinkValue
		{
					get { return CTALink.Value; }
				}
		/// <summary><para>Template: Image CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Image CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
		/// <summary><para>Template: Image CTA</para><para>Field: CTAImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper CTAImage
		{
			get { return GetField<ImageFieldWrapper>("CTA Image"); }
		}

		/// <summary><para>Template: Image CTA</para><para>Field: CTAImage</para><para>Data type: Image</para></summary>
 		public string CTAImageValue
		{
					get { return CTAImage.Value; }
				}
	
	}
}
#endregion
#region Footer Settings (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Footer Settings</para>
	/// <para>ID: {4E9CE934-BFC0-456F-983B-C8DCCD6E2F87}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Footer Settings</para>
	/// </summary>
	[TemplateMapping("{4E9CE934-BFC0-456F-983B-C8DCCD6E2F87}", "InterfaceMap")]
	public partial interface IFooterSettings : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSettings	{		
    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: CopywrightNotice</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("copywright_notice_t")]
		ITextFieldWrapper CopywrightNotice { get; }

    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: CopywrightNotice</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("copywright_notice")]
 		string CopywrightNoticeValue { get; }
    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: SiteByItem</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("site_by_item_s")]
		ILinkFieldWrapper SiteByItem { get; }

    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: SiteByItem</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("site_by_item")]
 		Guid SiteByItemValue { get; }
    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: SocialMediaLinks</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("social_media_links_sm")]
		IListFieldWrapper SocialMediaLinks { get; }

    	/// <summary>
		/// <para>Template: Footer Settings</para><para>Field: SocialMediaLinks</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("social_media_links")]
 		IEnumerable<Guid> SocialMediaLinksValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Footer Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4E9CE934-BFC0-456F-983B-C8DCCD6E2F87}", typeof(Guid))]
	[TemplateMapping("{4E9CE934-BFC0-456F-983B-C8DCCD6E2F87}", "")]
	public partial class FooterSettings : CustomItemWrapper, IFooterSettings
	{
		private Item _item = null;

		public FooterSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public FooterSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public FooterSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public FooterSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Footer Settings</para><para>Field: CopywrightNotice</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("copywright_notice_t")]
		public virtual ITextFieldWrapper CopywrightNotice
		{
			get { return GetField<TextFieldWrapper>("Copywright Notice", "copywright_notice_t"); }
		}

		/// <summary><para>Template: Footer Settings</para><para>Field: CopywrightNotice</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("copywright_notice")]
 		public string CopywrightNoticeValue
		{
					get { return CopywrightNotice.Value; }
				}
		/// <summary><para>Template: Footer Settings</para><para>Field: SiteByItem</para><para>Data type: Droplink</para></summary>
		[IndexField("site_by_item_s")]
		public virtual ILinkFieldWrapper SiteByItem
		{
			get { return GetField<LinkFieldWrapper>("Site by Item", "site_by_item_s"); }
		}

		/// <summary><para>Template: Footer Settings</para><para>Field: SiteByItem</para><para>Data type: Droplink</para></summary>
		[IndexField("site_by_item")]
 		public Guid SiteByItemValue
		{
					get { return SiteByItem.Value; }
				}
		/// <summary><para>Template: Footer Settings</para><para>Field: SocialMediaLinks</para><para>Data type: Multilist</para></summary>
		[IndexField("social_media_links_sm")]
		public virtual IListFieldWrapper SocialMediaLinks
		{
			get { return GetField<ListFieldWrapper>("Social Media Links", "social_media_links_sm"); }
		}

		/// <summary><para>Template: Footer Settings</para><para>Field: SocialMediaLinks</para><para>Data type: Multilist</para></summary>
		[IndexField("social_media_links")]
 		public IEnumerable<Guid> SocialMediaLinksValue
		{
					get { return SocialMediaLinks.Value; }
				}
	
	}
}
#endregion
#region Phrase Dictionary (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Phrase Dictionary</para>
	/// <para>ID: {59A892A5-11FA-4F2A-9E84-99B56DA2D294}</para>
	/// <para>/sitecore/templates/Ignite/Phrases/Phrase Dictionary</para>
	/// </summary>
	[TemplateMapping("{59A892A5-11FA-4F2A-9E84-99B56DA2D294}", "InterfaceMap")]
	public partial interface IPhraseDictionary : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Phrases/Phrase Dictionary</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{59A892A5-11FA-4F2A-9E84-99B56DA2D294}", typeof(Guid))]
	[TemplateMapping("{59A892A5-11FA-4F2A-9E84-99B56DA2D294}", "")]
	public partial class PhraseDictionary : CustomItemWrapper, IPhraseDictionary
	{
		private Item _item = null;

		public PhraseDictionary(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public PhraseDictionary(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public PhraseDictionary(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public PhraseDictionary(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Named Folder (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Named Folder</para>
	/// <para>ID: {5EEAC9B9-7A5B-4B0F-96C1-31A479726004}</para>
	/// <para>/sitecore/templates/Common/Named Folder</para>
	/// </summary>
	[TemplateMapping("{5EEAC9B9-7A5B-4B0F-96C1-31A479726004}", "InterfaceMap")]
	public partial interface INamedFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
    	/// <summary>
		/// <para>Template: Named Folder</para><para>Field: FolderTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("folder_title_t")]
		ITextFieldWrapper FolderTitle { get; }

    	/// <summary>
		/// <para>Template: Named Folder</para><para>Field: FolderTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("folder_title")]
 		string FolderTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Common/Named Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5EEAC9B9-7A5B-4B0F-96C1-31A479726004}", typeof(Guid))]
	[TemplateMapping("{5EEAC9B9-7A5B-4B0F-96C1-31A479726004}", "")]
	public partial class NamedFolder : CustomItemWrapper, INamedFolder
	{
		private Item _item = null;

		public NamedFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public NamedFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public NamedFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public NamedFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Named Folder</para><para>Field: FolderTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("folder_title_t")]
		public virtual ITextFieldWrapper FolderTitle
		{
			get { return GetField<TextFieldWrapper>("Folder_Title", "folder_title_t"); }
		}

		/// <summary><para>Template: Named Folder</para><para>Field: FolderTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("folder_title")]
 		public string FolderTitleValue
		{
					get { return FolderTitle.Value; }
				}
	
	}
}
#endregion
#region In The News Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: In The News Folder</para>
	/// <para>ID: {6DF95BDE-8860-4459-8F82-528117D2A461}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Media/In The News Folder</para>
	/// </summary>
	[TemplateMapping("{6DF95BDE-8860-4459-8F82-528117D2A461}", "InterfaceMap")]
	public partial interface IInTheNewsFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Media/In The News Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{6DF95BDE-8860-4459-8F82-528117D2A461}", typeof(Guid))]
	[TemplateMapping("{6DF95BDE-8860-4459-8F82-528117D2A461}", "")]
	public partial class InTheNewsFolder : CustomItemWrapper, IInTheNewsFolder
	{
		private Item _item = null;

		public InTheNewsFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public InTheNewsFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public InTheNewsFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public InTheNewsFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Landing Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Landing Page</para>
	/// <para>ID: {70DA93AB-FF30-4B87-8DD5-BEE41CA94AF5}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Landing Page</para>
	/// </summary>
	[TemplateMapping("{70DA93AB-FF30-4B87-8DD5-BEE41CA94AF5}", "InterfaceMap")]
	public partial interface ILandingPage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IChildContentPage	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Landing Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{70DA93AB-FF30-4B87-8DD5-BEE41CA94AF5}", typeof(Guid))]
	[TemplateMapping("{70DA93AB-FF30-4B87-8DD5-BEE41CA94AF5}", "")]
	public partial class LandingPage : CustomItemWrapper, ILandingPage
	{
		private Item _item = null;

		public LandingPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public LandingPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public LandingPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public LandingPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Landing Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: Landing Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Landing Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region Content Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Page</para>
	/// <para>ID: {752F1533-1F90-46AB-A98E-4704AB2F2EEE}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Content Page</para>
	/// </summary>
	[TemplateMapping("{752F1533-1F90-46AB-A98E-4704AB2F2EEE}", "InterfaceMap")]
	public partial interface IContentPage : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate, LM.Model.Templates.PokerCentral.INavigation, LM.Model.Templates.PokerCentral.IContent, LM.Model.Templates.PokerCentral.IMetaData	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Base/Page Types/Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{752F1533-1F90-46AB-A98E-4704AB2F2EEE}", typeof(Guid))]
	[TemplateMapping("{752F1533-1F90-46AB-A98E-4704AB2F2EEE}", "")]
	public partial class ContentPage : CustomItemWrapper, IContentPage
	{
		private Item _item = null;

		public ContentPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
	
	}
}
#endregion
#region Available Devices List Rendering Parameters (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Available Devices List Rendering Parameters</para>
	/// <para>ID: {756471B6-C024-45FB-9F91-594357E6AF9F}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Devices/Rendering Parameters/Available Devices List Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{756471B6-C024-45FB-9F91-594357E6AF9F}", "InterfaceRenderingParameter")]
	public partial interface IAvailableDevicesListRenderingParameters : IRenderingParameterWrapper , LM.Model.Templates.Ignite.IIgniteRenderingParameters	{		
    	/// <summary>
		/// <para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableNowLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper AvailableNowLabel { get; }
 		Guid AvailableNowLabelValue { get; }
    	/// <summary>
		/// <para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableSoonLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper AvailableSoonLabel { get; }
 		Guid AvailableSoonLabelValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Devices/Rendering Parameters/Available Devices List Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{756471B6-C024-45FB-9F91-594357E6AF9F}", typeof(Guid))]
	[TemplateMapping("{756471B6-C024-45FB-9F91-594357E6AF9F}", "RenderingParameter")]
	public partial class AvailableDevicesListRenderingParameters : RenderingParameterWrapper, IAvailableDevicesListRenderingParameters
	{
		public AvailableDevicesListRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableNowLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper AvailableNowLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Available Now Label", "droptree"); }
		}

		/// <summary><para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableNowLabel</para><para>Data type: Droptree</para></summary>
 		public Guid AvailableNowLabelValue
		{
					get { return AvailableNowLabel.Value; }
				}
		/// <summary><para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableSoonLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper AvailableSoonLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Available Soon Label", "droptree"); }
		}

		/// <summary><para>Template: Available Devices List Rendering Parameters</para><para>Field: AvailableSoonLabel</para><para>Data type: Droptree</para></summary>
 		public Guid AvailableSoonLabelValue
		{
					get { return AvailableSoonLabel.Value; }
				}
	
	}
}
#endregion
#region Document (ScSystem)
namespace LM.Model.Templates.ScSystem
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Document</para>
	/// <para>ID: {777F0C76-D712-46EA-9F40-371ACDA18A1C}</para>
	/// <para>/sitecore/templates/System/Media/Unversioned/Document</para>
	/// </summary>
	[TemplateMapping("{777F0C76-D712-46EA-9F40-371ACDA18A1C}", "InterfaceMap")]
	public partial interface IDocument : ICustomItemWrapper , LM.Model.Templates.ScSystem.IFile	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/System/Media/Unversioned/Document</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{777F0C76-D712-46EA-9F40-371ACDA18A1C}", typeof(Guid))]
	[TemplateMapping("{777F0C76-D712-46EA-9F40-371ACDA18A1C}", "")]
	public partial class Document : CustomItemWrapper, IDocument
	{
		private Item _item = null;

		public Document(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Document(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Document(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Document(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Document</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension_t")]
		public virtual ITextFieldWrapper Extension
		{
			get { return GetField<TextFieldWrapper>("Extension", "extension_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension")]
 		public string ExtensionValue
		{
					get { return Extension.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
 		public string KeywordsValue
		{
					get { return Keywords.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type_t")]
		public virtual ITextFieldWrapper MimeType
		{
			get { return GetField<TextFieldWrapper>("Mime Type", "mime_type_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type")]
 		public string MimeTypeValue
		{
					get { return MimeType.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size_t")]
		public virtual ITextFieldWrapper Size
		{
			get { return GetField<TextFieldWrapper>("Size", "size_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size")]
 		public string SizeValue
		{
					get { return Size.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
					get { return Title.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode_t")]
		public virtual ITextFieldWrapper CountryCode
		{
			get { return GetField<TextFieldWrapper>("CountryCode", "countrycode_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode")]
 		public string CountryCodeValue
		{
					get { return CountryCode.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude_tf")]
		public virtual INumberFieldWrapper Latitude
		{
			get { return GetField<NumberFieldWrapper>("Latitude", "latitude_tf"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude")]
 		public float LatitudeValue
		{
					get { return Latitude.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription_t")]
		public virtual ITextFieldWrapper LocationDescription
		{
			get { return GetField<TextFieldWrapper>("LocationDescription", "locationdescription_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription")]
 		public string LocationDescriptionValue
		{
					get { return LocationDescription.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude_tf")]
		public virtual INumberFieldWrapper Longitude
		{
			get { return GetField<NumberFieldWrapper>("Longitude", "longitude_tf"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude")]
 		public float LongitudeValue
		{
					get { return Longitude.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode_t")]
		public virtual ITextFieldWrapper ZipCode
		{
			get { return GetField<TextFieldWrapper>("ZipCode", "zipcode_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode")]
 		public string ZipCodeValue
		{
					get { return ZipCode.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
		public virtual ITextFieldWrapper Blob
		{
			get { return GetField<TextFieldWrapper>("Blob"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
 		public string BlobValue
		{
					get { return Blob.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path_t")]
		public virtual ITextFieldWrapper FilePath
		{
			get { return GetField<TextFieldWrapper>("File Path", "file_path_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path")]
 		public string FilePathValue
		{
					get { return FilePath.Value; }
				}
		/// <summary><para>Template: Document</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format_t")]
		public virtual ITextFieldWrapper Format
		{
			get { return GetField<TextFieldWrapper>("Format", "format_t"); }
		}

		/// <summary><para>Template: Document</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format")]
 		public string FormatValue
		{
					get { return Format.Value; }
				}
	
	}
}
#endregion
#region Site Settings (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Site Settings</para>
	/// <para>ID: {7F2B1F43-C2B3-4872-9580-D9D80ED942B0}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Site Settings</para>
	/// </summary>
	[TemplateMapping("{7F2B1F43-C2B3-4872-9580-D9D80ED942B0}", "InterfaceMap")]
	public partial interface ISiteSettings : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSettings	{		
    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: CountDownDate</para><para>Data type: Datetime</para>
        /// </summary>
		[IndexField("count_down_date_tdt")]
		IDateTimeFieldWrapper CountDownDate { get; }

    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: CountDownDate</para><para>Data type: Datetime</para>
        /// </summary>
		[IndexField("count_down_date")]
 		DateTime CountDownDateValue { get; }
    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: IsCountDownEnabled</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("is_count_down_enabled_b")]
		IBooleanFieldWrapper IsCountDownEnabled { get; }

    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: IsCountDownEnabled</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("is_count_down_enabled")]
 		bool IsCountDownEnabledValue { get; }
    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: MailListClientId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("mail_list_client_id_t")]
		ITextFieldWrapper MailListClientId { get; }

    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: MailListClientId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("mail_list_client_id")]
 		string MailListClientIdValue { get; }
    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: MailListListId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("mail_list_list_id_t")]
		ITextFieldWrapper MailListListId { get; }

    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: MailListListId</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("mail_list_list_id")]
 		string MailListListIdValue { get; }
    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: VideoSharePage</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("video_share_page_s")]
		ILinkFieldWrapper VideoSharePage { get; }

    	/// <summary>
		/// <para>Template: Site Settings</para><para>Field: VideoSharePage</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("video_share_page")]
 		Guid VideoSharePageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Site Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{7F2B1F43-C2B3-4872-9580-D9D80ED942B0}", typeof(Guid))]
	[TemplateMapping("{7F2B1F43-C2B3-4872-9580-D9D80ED942B0}", "")]
	public partial class SiteSettings : CustomItemWrapper, ISiteSettings
	{
		private Item _item = null;

		public SiteSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Site Settings</para><para>Field: CountDownDate</para><para>Data type: Datetime</para></summary>
		[IndexField("count_down_date_tdt")]
		public virtual IDateTimeFieldWrapper CountDownDate
		{
			get { return GetField<DateTimeFieldWrapper>("Count Down Date", "count_down_date_tdt"); }
		}

		/// <summary><para>Template: Site Settings</para><para>Field: CountDownDate</para><para>Data type: Datetime</para></summary>
		[IndexField("count_down_date")]
 		public DateTime CountDownDateValue
		{
					get { return CountDownDate.Value; }
				}
		/// <summary><para>Template: Site Settings</para><para>Field: IsCountDownEnabled</para><para>Data type: Checkbox</para></summary>
		[IndexField("is_count_down_enabled_b")]
		public virtual IBooleanFieldWrapper IsCountDownEnabled
		{
			get { return GetField<BooleanFieldWrapper>("Is Count Down Enabled", "is_count_down_enabled_b"); }
		}

		/// <summary><para>Template: Site Settings</para><para>Field: IsCountDownEnabled</para><para>Data type: Checkbox</para></summary>
		[IndexField("is_count_down_enabled")]
 		public bool IsCountDownEnabledValue
		{
					get { return IsCountDownEnabled.Value; }
				}
		/// <summary><para>Template: Site Settings</para><para>Field: MailListClientId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mail_list_client_id_t")]
		public virtual ITextFieldWrapper MailListClientId
		{
			get { return GetField<TextFieldWrapper>("Mail List Client Id", "mail_list_client_id_t"); }
		}

		/// <summary><para>Template: Site Settings</para><para>Field: MailListClientId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mail_list_client_id")]
 		public string MailListClientIdValue
		{
					get { return MailListClientId.Value; }
				}
		/// <summary><para>Template: Site Settings</para><para>Field: MailListListId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mail_list_list_id_t")]
		public virtual ITextFieldWrapper MailListListId
		{
			get { return GetField<TextFieldWrapper>("Mail List List Id", "mail_list_list_id_t"); }
		}

		/// <summary><para>Template: Site Settings</para><para>Field: MailListListId</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mail_list_list_id")]
 		public string MailListListIdValue
		{
					get { return MailListListId.Value; }
				}
		/// <summary><para>Template: Site Settings</para><para>Field: VideoSharePage</para><para>Data type: Droptree</para></summary>
		[IndexField("video_share_page_s")]
		public virtual ILinkFieldWrapper VideoSharePage
		{
			get { return GetField<LinkFieldWrapper>("Video Share Page", "video_share_page_s"); }
		}

		/// <summary><para>Template: Site Settings</para><para>Field: VideoSharePage</para><para>Data type: Droptree</para></summary>
		[IndexField("video_share_page")]
 		public Guid VideoSharePageValue
		{
					get { return VideoSharePage.Value; }
				}
	
	}
}
#endregion
#region Sponsors (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Sponsors</para>
	/// <para>ID: {8104D759-1D1C-405B-82C2-EAFE2EC15C7E}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Sponsors</para>
	/// </summary>
	[TemplateMapping("{8104D759-1D1C-405B-82C2-EAFE2EC15C7E}", "InterfaceMap")]
	public partial interface ISponsors : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Sponsors</para><para>Field: SponsoredBackground</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper SponsoredBackground { get; }
 		string SponsoredBackgroundValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Sponsors</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8104D759-1D1C-405B-82C2-EAFE2EC15C7E}", typeof(Guid))]
	[TemplateMapping("{8104D759-1D1C-405B-82C2-EAFE2EC15C7E}", "")]
	public partial class Sponsors : CustomItemWrapper, ISponsors
	{
		private Item _item = null;

		public Sponsors(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Sponsors(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Sponsors(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Sponsors(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Sponsors</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Sponsors</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region Image Phrase (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Image Phrase</para>
	/// <para>ID: {813A77F9-58C3-4941-BD97-5BFCE4727F4A}</para>
	/// <para>/sitecore/templates/Ignite/Phrases/Image Phrase</para>
	/// </summary>
	[TemplateMapping("{813A77F9-58C3-4941-BD97-5BFCE4727F4A}", "InterfaceMap")]
	public partial interface IImagePhrase : ICustomItemWrapper , LM.Model.Templates.Ignite.IPhrase	{		
    	/// <summary>
		/// <para>Template: Image Phrase</para><para>Field: Phrase</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper Phrase { get; }
 		string PhraseValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Phrases/Image Phrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{813A77F9-58C3-4941-BD97-5BFCE4727F4A}", typeof(Guid))]
	[TemplateMapping("{813A77F9-58C3-4941-BD97-5BFCE4727F4A}", "")]
	public partial class ImagePhrase : CustomItemWrapper, IImagePhrase
	{
		private Item _item = null;

		public ImagePhrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ImagePhrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ImagePhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ImagePhrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Image Phrase</para><para>Field: Phrase</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Phrase
		{
			get { return GetField<ImageFieldWrapper>("Phrase"); }
		}

		/// <summary><para>Template: Image Phrase</para><para>Field: Phrase</para><para>Data type: Image</para></summary>
 		public string PhraseValue
		{
					get { return Phrase.Value; }
				}
	
	}
}
#endregion
#region Ignite Wildcard Template (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ignite Wildcard Template</para>
	/// <para>ID: {84A7C848-246D-4E21-9164-5B0EFA1AAC9D}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Wildcard Template</para>
	/// </summary>
	[TemplateMapping("{84A7C848-246D-4E21-9164-5B0EFA1AAC9D}", "InterfaceMap")]
	public partial interface IIgniteWildcardTemplate : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Ignite Wildcard Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_token_s")]
		ILinkFieldWrapper ItemBucketsWildcardToken { get; }

    	/// <summary>
		/// <para>Template: Ignite Wildcard Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_token")]
 		Guid ItemBucketsWildcardTokenValue { get; }
    	/// <summary>
		/// <para>Template: Ignite Wildcard Template</para><para>Field: WildcardItemBucket</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("__wildcarditembucket_s")]
		ILinkFieldWrapper WildcardItemBucket { get; }

    	/// <summary>
		/// <para>Template: Ignite Wildcard Template</para><para>Field: WildcardItemBucket</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("__wildcarditembucket")]
 		Guid WildcardItemBucketValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Ignite Wildcard Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{84A7C848-246D-4E21-9164-5B0EFA1AAC9D}", typeof(Guid))]
	[TemplateMapping("{84A7C848-246D-4E21-9164-5B0EFA1AAC9D}", "")]
	public partial class IgniteWildcardTemplate : CustomItemWrapper, IIgniteWildcardTemplate
	{
		private Item _item = null;

		public IgniteWildcardTemplate(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public IgniteWildcardTemplate(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public IgniteWildcardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public IgniteWildcardTemplate(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token_s")]
		public virtual ILinkFieldWrapper ItemBucketsWildcardToken
		{
			get { return GetField<LinkFieldWrapper>("Item Buckets Wildcard Token", "item_buckets_wildcard_token_s"); }
		}

		/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
 		public Guid ItemBucketsWildcardTokenValue
		{
					get { return ItemBucketsWildcardToken.Value; }
				}
		/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: WildcardItemBucket</para><para>Data type: Droptree</para></summary>
		[IndexField("__wildcarditembucket_s")]
		public virtual ILinkFieldWrapper WildcardItemBucket
		{
			get { return GetField<LinkFieldWrapper>("__WildcardItemBucket", "__wildcarditembucket_s"); }
		}

		/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: WildcardItemBucket</para><para>Data type: Droptree</para></summary>
		[IndexField("__wildcarditembucket")]
 		public Guid WildcardItemBucketValue
		{
					get { return WildcardItemBucket.Value; }
				}
	
	}
}
#endregion
#region Base Slide (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Base Slide</para>
	/// <para>ID: {88790B8F-3A30-49D0-B57D-0E9EABCDFD0C}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Base Slide</para>
	/// </summary>
	[TemplateMapping("{88790B8F-3A30-49D0-B57D-0E9EABCDFD0C}", "InterfaceMap")]
	public partial interface IBaseSlide : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_text_t")]
		ITextFieldWrapper CTAText { get; }

    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_text")]
 		string CTATextValue { get; }
    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper BackgroundImageMobile { get; }
 		string BackgroundImageMobileValue { get; }
    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper BackgroundImage { get; }
 		string BackgroundImageValue { get; }
    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("slide_description_t")]
		ITextFieldWrapper SlideDescription { get; }

    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("slide_description")]
 		string SlideDescriptionValue { get; }
    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("slide_title_t")]
		ITextFieldWrapper SlideTitle { get; }

    	/// <summary>
		/// <para>Template: Base Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("slide_title")]
 		string SlideTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Featured Slider/Base Slide</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{88790B8F-3A30-49D0-B57D-0E9EABCDFD0C}", typeof(Guid))]
	[TemplateMapping("{88790B8F-3A30-49D0-B57D-0E9EABCDFD0C}", "")]
	public partial class BaseSlide : CustomItemWrapper, IBaseSlide
	{
		private Item _item = null;

		public BaseSlide(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BaseSlide(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BaseSlide(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BaseSlide(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Base Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Base Slide</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
		/// <summary><para>Template: Base Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImageMobile
		{
			get { return GetField<ImageFieldWrapper>("Background Image Mobile"); }
		}

		/// <summary><para>Template: Base Slide</para><para>Field: BackgroundImageMobile</para><para>Data type: Image</para></summary>
 		public string BackgroundImageMobileValue
		{
					get { return BackgroundImageMobile.Value; }
				}
		/// <summary><para>Template: Base Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper BackgroundImage
		{
			get { return GetField<ImageFieldWrapper>("Background Image"); }
		}

		/// <summary><para>Template: Base Slide</para><para>Field: BackgroundImage</para><para>Data type: Image</para></summary>
 		public string BackgroundImageValue
		{
					get { return BackgroundImage.Value; }
				}
		/// <summary><para>Template: Base Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description_t")]
		public virtual ITextFieldWrapper SlideDescription
		{
			get { return GetField<TextFieldWrapper>("Slide Description", "slide_description_t"); }
		}

		/// <summary><para>Template: Base Slide</para><para>Field: SlideDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("slide_description")]
 		public string SlideDescriptionValue
		{
					get { return SlideDescription.Value; }
				}
		/// <summary><para>Template: Base Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title_t")]
		public virtual ITextFieldWrapper SlideTitle
		{
			get { return GetField<TextFieldWrapper>("Slide Title", "slide_title_t"); }
		}

		/// <summary><para>Template: Base Slide</para><para>Field: SlideTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("slide_title")]
 		public string SlideTitleValue
		{
					get { return SlideTitle.Value; }
				}
	
	}
}
#endregion
#region Ignite Bucket Template (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ignite Bucket Template</para>
	/// <para>ID: {88DD19F6-A03C-412C-AB52-5515342FC30D}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Bucket Template</para>
	/// </summary>
	[TemplateMapping("{88DD19F6-A03C-412C-AB52-5515342FC30D}", "InterfaceMap")]
	public partial interface IIgniteBucketTemplate : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardItem</para><para>Data type: Treelist</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_item_sm")]
		IListFieldWrapper ItemBucketsWildcardItem { get; }

    	/// <summary>
		/// <para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardItem</para><para>Data type: Treelist</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_item")]
 		IEnumerable<Guid> ItemBucketsWildcardItemValue { get; }
    	/// <summary>
		/// <para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_token_s")]
		ILinkFieldWrapper ItemBucketsWildcardToken { get; }

    	/// <summary>
		/// <para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para>
        /// </summary>
		[IndexField("item_buckets_wildcard_token")]
 		Guid ItemBucketsWildcardTokenValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Ignite Bucket Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{88DD19F6-A03C-412C-AB52-5515342FC30D}", typeof(Guid))]
	[TemplateMapping("{88DD19F6-A03C-412C-AB52-5515342FC30D}", "")]
	public partial class IgniteBucketTemplate : CustomItemWrapper, IIgniteBucketTemplate
	{
		private Item _item = null;

		public IgniteBucketTemplate(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public IgniteBucketTemplate(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public IgniteBucketTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public IgniteBucketTemplate(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardItem</para><para>Data type: Treelist</para></summary>
		[IndexField("item_buckets_wildcard_item_sm")]
		public virtual IListFieldWrapper ItemBucketsWildcardItem
		{
			get { return GetField<ListFieldWrapper>("Item Buckets Wildcard Item", "item_buckets_wildcard_item_sm"); }
		}

		/// <summary><para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardItem</para><para>Data type: Treelist</para></summary>
		[IndexField("item_buckets_wildcard_item")]
 		public IEnumerable<Guid> ItemBucketsWildcardItemValue
		{
					get { return ItemBucketsWildcardItem.Value; }
				}
		/// <summary><para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token_s")]
		public virtual ILinkFieldWrapper ItemBucketsWildcardToken
		{
			get { return GetField<LinkFieldWrapper>("Item Buckets Wildcard Token", "item_buckets_wildcard_token_s"); }
		}

		/// <summary><para>Template: Ignite Bucket Template</para><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
 		public Guid ItemBucketsWildcardTokenValue
		{
					get { return ItemBucketsWildcardToken.Value; }
				}
	
	}
}
#endregion
#region Contact Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contact Folder</para>
	/// <para>ID: {8D663B9D-53AC-412C-B158-9E15BC1EBB94}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Contact Folder</para>
	/// </summary>
	[TemplateMapping("{8D663B9D-53AC-412C-B158-9E15BC1EBB94}", "InterfaceMap")]
	public partial interface IContactFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Contacts/Contact Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8D663B9D-53AC-412C-B158-9E15BC1EBB94}", typeof(Guid))]
	[TemplateMapping("{8D663B9D-53AC-412C-B158-9E15BC1EBB94}", "")]
	public partial class ContactFolder : CustomItemWrapper, IContactFolder
	{
		private Item _item = null;

		public ContactFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContactFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContactFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContactFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region OoyalaAccount (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaAccount</para>
	/// <para>ID: {94A5527D-1B95-44C7-8DF3-D61F41379B17}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaAccount</para>
	/// </summary>
	[TemplateMapping("{94A5527D-1B95-44C7-8DF3-D61F41379B17}", "InterfaceMap")]
	public partial interface IOoyalaAccount : ICustomItemWrapper 	{		
    	/// <summary>
		/// <para>Template: OoyalaAccount</para><para>Field: APIKey</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("apikey_t")]
		ITextFieldWrapper APIKey { get; }

    	/// <summary>
		/// <para>Template: OoyalaAccount</para><para>Field: APIKey</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("apikey")]
 		string APIKeyValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaAccount</para><para>Field: APISecret</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("apisecret_t")]
		ITextFieldWrapper APISecret { get; }

    	/// <summary>
		/// <para>Template: OoyalaAccount</para><para>Field: APISecret</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("apisecret")]
 		string APISecretValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaAccount</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{94A5527D-1B95-44C7-8DF3-D61F41379B17}", typeof(Guid))]
	[TemplateMapping("{94A5527D-1B95-44C7-8DF3-D61F41379B17}", "")]
	public partial class OoyalaAccount : CustomItemWrapper, IOoyalaAccount
	{
		private Item _item = null;

		public OoyalaAccount(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaAccount(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaAccount(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaAccount(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaAccount</para><para>Field: APIKey</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("apikey_t")]
		public virtual ITextFieldWrapper APIKey
		{
			get { return GetField<TextFieldWrapper>("APIKey", "apikey_t"); }
		}

		/// <summary><para>Template: OoyalaAccount</para><para>Field: APIKey</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("apikey")]
 		public string APIKeyValue
		{
					get { return APIKey.Value; }
				}
		/// <summary><para>Template: OoyalaAccount</para><para>Field: APISecret</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("apisecret_t")]
		public virtual ITextFieldWrapper APISecret
		{
			get { return GetField<TextFieldWrapper>("APISecret", "apisecret_t"); }
		}

		/// <summary><para>Template: OoyalaAccount</para><para>Field: APISecret</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("apisecret")]
 		public string APISecretValue
		{
					get { return APISecret.Value; }
				}
	
	}
}
#endregion
#region File (ScSystem)
namespace LM.Model.Templates.ScSystem
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: File</para>
	/// <para>ID: {962B53C4-F93B-4DF9-9821-415C867B8903}</para>
	/// <para>/sitecore/templates/System/Media/Unversioned/File</para>
	/// </summary>
	[TemplateMapping("{962B53C4-F93B-4DF9-9821-415C867B8903}", "InterfaceMap")]
	public partial interface IFile : ICustomItemWrapper 	{		
    	/// <summary>
		/// <para>Template: File</para><para>Field: Description</para><para>Data type: text</para>
        /// </summary>
		[IndexField("description_t")]
		ITextFieldWrapper Description { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Description</para><para>Data type: text</para>
        /// </summary>
		[IndexField("description")]
 		string DescriptionValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Extension</para><para>Data type: text</para>
        /// </summary>
		[IndexField("extension_t")]
		ITextFieldWrapper Extension { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Extension</para><para>Data type: text</para>
        /// </summary>
		[IndexField("extension")]
 		string ExtensionValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Keywords</para><para>Data type: memo</para>
        /// </summary>
		ITextFieldWrapper Keywords { get; }
 		string KeywordsValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: MimeType</para><para>Data type: text</para>
        /// </summary>
		[IndexField("mime_type_t")]
		ITextFieldWrapper MimeType { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: MimeType</para><para>Data type: text</para>
        /// </summary>
		[IndexField("mime_type")]
 		string MimeTypeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Size</para><para>Data type: text</para>
        /// </summary>
		[IndexField("size_t")]
		ITextFieldWrapper Size { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Size</para><para>Data type: text</para>
        /// </summary>
		[IndexField("size")]
 		string SizeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Title</para><para>Data type: text</para>
        /// </summary>
		[IndexField("title_t")]
		ITextFieldWrapper Title { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Title</para><para>Data type: text</para>
        /// </summary>
		[IndexField("title")]
 		string TitleValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("countrycode_t")]
		ITextFieldWrapper CountryCode { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("countrycode")]
 		string CountryCodeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Latitude</para><para>Data type: Number</para>
        /// </summary>
		[IndexField("latitude_tf")]
		INumberFieldWrapper Latitude { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Latitude</para><para>Data type: Number</para>
        /// </summary>
		[IndexField("latitude")]
 		float LatitudeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("locationdescription_t")]
		ITextFieldWrapper LocationDescription { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("locationdescription")]
 		string LocationDescriptionValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Longitude</para><para>Data type: Number</para>
        /// </summary>
		[IndexField("longitude_tf")]
		INumberFieldWrapper Longitude { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Longitude</para><para>Data type: Number</para>
        /// </summary>
		[IndexField("longitude")]
 		float LongitudeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("zipcode_t")]
		ITextFieldWrapper ZipCode { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("zipcode")]
 		string ZipCodeValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Blob</para><para>Data type: attachment</para>
        /// </summary>
		ITextFieldWrapper Blob { get; }
 		string BlobValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: FilePath</para><para>Data type: text</para>
        /// </summary>
		[IndexField("file_path_t")]
		ITextFieldWrapper FilePath { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: FilePath</para><para>Data type: text</para>
        /// </summary>
		[IndexField("file_path")]
 		string FilePathValue { get; }
    	/// <summary>
		/// <para>Template: File</para><para>Field: Format</para><para>Data type: text</para>
        /// </summary>
		[IndexField("format_t")]
		ITextFieldWrapper Format { get; }

    	/// <summary>
		/// <para>Template: File</para><para>Field: Format</para><para>Data type: text</para>
        /// </summary>
		[IndexField("format")]
 		string FormatValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/System/Media/Unversioned/File</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{962B53C4-F93B-4DF9-9821-415C867B8903}", typeof(Guid))]
	[TemplateMapping("{962B53C4-F93B-4DF9-9821-415C867B8903}", "")]
	public partial class File : CustomItemWrapper, IFile
	{
		private Item _item = null;

		public File(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public File(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public File(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public File(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: File</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: Description</para><para>Data type: text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension_t")]
		public virtual ITextFieldWrapper Extension
		{
			get { return GetField<TextFieldWrapper>("Extension", "extension_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: Extension</para><para>Data type: text</para></summary>
		[IndexField("extension")]
 		public string ExtensionValue
		{
					get { return Extension.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords"); }
		}

		/// <summary><para>Template: File</para><para>Field: Keywords</para><para>Data type: memo</para></summary>
 		public string KeywordsValue
		{
					get { return Keywords.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type_t")]
		public virtual ITextFieldWrapper MimeType
		{
			get { return GetField<TextFieldWrapper>("Mime Type", "mime_type_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: MimeType</para><para>Data type: text</para></summary>
		[IndexField("mime_type")]
 		public string MimeTypeValue
		{
					get { return MimeType.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size_t")]
		public virtual ITextFieldWrapper Size
		{
			get { return GetField<TextFieldWrapper>("Size", "size_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: Size</para><para>Data type: text</para></summary>
		[IndexField("size")]
 		public string SizeValue
		{
					get { return Size.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: Title</para><para>Data type: text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
					get { return Title.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode_t")]
		public virtual ITextFieldWrapper CountryCode
		{
			get { return GetField<TextFieldWrapper>("CountryCode", "countrycode_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: CountryCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("countrycode")]
 		public string CountryCodeValue
		{
					get { return CountryCode.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude_tf")]
		public virtual INumberFieldWrapper Latitude
		{
			get { return GetField<NumberFieldWrapper>("Latitude", "latitude_tf"); }
		}

		/// <summary><para>Template: File</para><para>Field: Latitude</para><para>Data type: Number</para></summary>
		[IndexField("latitude")]
 		public float LatitudeValue
		{
					get { return Latitude.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription_t")]
		public virtual ITextFieldWrapper LocationDescription
		{
			get { return GetField<TextFieldWrapper>("LocationDescription", "locationdescription_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: LocationDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("locationdescription")]
 		public string LocationDescriptionValue
		{
					get { return LocationDescription.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude_tf")]
		public virtual INumberFieldWrapper Longitude
		{
			get { return GetField<NumberFieldWrapper>("Longitude", "longitude_tf"); }
		}

		/// <summary><para>Template: File</para><para>Field: Longitude</para><para>Data type: Number</para></summary>
		[IndexField("longitude")]
 		public float LongitudeValue
		{
					get { return Longitude.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode_t")]
		public virtual ITextFieldWrapper ZipCode
		{
			get { return GetField<TextFieldWrapper>("ZipCode", "zipcode_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: ZipCode</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("zipcode")]
 		public string ZipCodeValue
		{
					get { return ZipCode.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
		public virtual ITextFieldWrapper Blob
		{
			get { return GetField<TextFieldWrapper>("Blob"); }
		}

		/// <summary><para>Template: File</para><para>Field: Blob</para><para>Data type: attachment</para></summary>
 		public string BlobValue
		{
					get { return Blob.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path_t")]
		public virtual ITextFieldWrapper FilePath
		{
			get { return GetField<TextFieldWrapper>("File Path", "file_path_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: FilePath</para><para>Data type: text</para></summary>
		[IndexField("file_path")]
 		public string FilePathValue
		{
					get { return FilePath.Value; }
				}
		/// <summary><para>Template: File</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format_t")]
		public virtual ITextFieldWrapper Format
		{
			get { return GetField<TextFieldWrapper>("Format", "format_t"); }
		}

		/// <summary><para>Template: File</para><para>Field: Format</para><para>Data type: text</para></summary>
		[IndexField("format")]
 		public string FormatValue
		{
					get { return Format.Value; }
				}
	
	}
}
#endregion
#region Meta Data (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Meta Data</para>
	/// <para>ID: {9A0ABA02-4903-4E04-8397-5528E6A358DE}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/SEO/Meta Data</para>
	/// </summary>
	[TemplateMapping("{9A0ABA02-4903-4E04-8397-5528E6A358DE}", "InterfaceMap")]
	public partial interface IMetaData : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("meta_canonical_url_t")]
		IGeneralLinkFieldWrapper MetaCanonicalUrl { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("meta_canonical_url")]
 		string MetaCanonicalUrlValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("meta_description_t")]
		ITextFieldWrapper MetaDescription { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("meta_description")]
 		string MetaDescriptionValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaImage</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper MetaImage { get; }
 		string MetaImageValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_keywords_t")]
		ITextFieldWrapper MetaKeywords { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_keywords")]
 		string MetaKeywordsValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_title_t")]
		ITextFieldWrapper MetaTitle { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("meta_title")]
 		string MetaTitleValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_sitemap_b")]
		IBooleanFieldWrapper HideFromSitemap { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_sitemap")]
 		bool HideFromSitemapValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/SEO/Meta Data</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{9A0ABA02-4903-4E04-8397-5528E6A358DE}", typeof(Guid))]
	[TemplateMapping("{9A0ABA02-4903-4E04-8397-5528E6A358DE}", "")]
	public partial class MetaData : CustomItemWrapper, IMetaData
	{
		private Item _item = null;

		public MetaData(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public MetaData(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public MetaData(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public MetaData(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Meta Data</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Meta Data</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Meta Data</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Meta Data</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Meta Data</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
	
	}
}
#endregion
#region Executive (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Executive</para>
	/// <para>ID: {9A1530D0-1EBC-4D84-A32F-68B928255064}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Executives/Executive</para>
	/// </summary>
	[TemplateMapping("{9A1530D0-1EBC-4D84-A32F-68B928255064}", "InterfaceMap")]
	public partial interface IExecutive : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Executive</para><para>Field: BioIntroduction</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("bio_introduction_t")]
		ITextFieldWrapper BioIntroduction { get; }

    	/// <summary>
		/// <para>Template: Executive</para><para>Field: BioIntroduction</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("bio_introduction")]
 		string BioIntroductionValue { get; }
    	/// <summary>
		/// <para>Template: Executive</para><para>Field: Bio</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("bio_t")]
		ITextFieldWrapper Bio { get; }

    	/// <summary>
		/// <para>Template: Executive</para><para>Field: Bio</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("bio")]
 		string BioValue { get; }
    	/// <summary>
		/// <para>Template: Executive</para><para>Field: FullName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("full_name_t")]
		ITextFieldWrapper FullName { get; }

    	/// <summary>
		/// <para>Template: Executive</para><para>Field: FullName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("full_name")]
 		string FullNameValue { get; }
    	/// <summary>
		/// <para>Template: Executive</para><para>Field: Headshot</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper Headshot { get; }
 		string HeadshotValue { get; }
    	/// <summary>
		/// <para>Template: Executive</para><para>Field: Position</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("position_t")]
		ITextFieldWrapper Position { get; }

    	/// <summary>
		/// <para>Template: Executive</para><para>Field: Position</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("position")]
 		string PositionValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Executives/Executive</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{9A1530D0-1EBC-4D84-A32F-68B928255064}", typeof(Guid))]
	[TemplateMapping("{9A1530D0-1EBC-4D84-A32F-68B928255064}", "")]
	public partial class Executive : CustomItemWrapper, IExecutive
	{
		private Item _item = null;

		public Executive(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Executive(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Executive(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Executive(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Executive</para><para>Field: BioIntroduction</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("bio_introduction_t")]
		public virtual ITextFieldWrapper BioIntroduction
		{
			get { return GetField<TextFieldWrapper>("Bio Introduction", "bio_introduction_t"); }
		}

		/// <summary><para>Template: Executive</para><para>Field: BioIntroduction</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("bio_introduction")]
 		public string BioIntroductionValue
		{
					get { return BioIntroduction.Value; }
				}
		/// <summary><para>Template: Executive</para><para>Field: Bio</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("bio_t")]
		public virtual ITextFieldWrapper Bio
		{
			get { return GetField<TextFieldWrapper>("Bio", "bio_t"); }
		}

		/// <summary><para>Template: Executive</para><para>Field: Bio</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("bio")]
 		public string BioValue
		{
					get { return Bio.Value; }
				}
		/// <summary><para>Template: Executive</para><para>Field: FullName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("full_name_t")]
		public virtual ITextFieldWrapper FullName
		{
			get { return GetField<TextFieldWrapper>("Full Name", "full_name_t"); }
		}

		/// <summary><para>Template: Executive</para><para>Field: FullName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("full_name")]
 		public string FullNameValue
		{
					get { return FullName.Value; }
				}
		/// <summary><para>Template: Executive</para><para>Field: Headshot</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Headshot
		{
			get { return GetField<ImageFieldWrapper>("Headshot"); }
		}

		/// <summary><para>Template: Executive</para><para>Field: Headshot</para><para>Data type: Image</para></summary>
 		public string HeadshotValue
		{
					get { return Headshot.Value; }
				}
		/// <summary><para>Template: Executive</para><para>Field: Position</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("position_t")]
		public virtual ITextFieldWrapper Position
		{
			get { return GetField<TextFieldWrapper>("Position", "position_t"); }
		}

		/// <summary><para>Template: Executive</para><para>Field: Position</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("position")]
 		public string PositionValue
		{
					get { return Position.Value; }
				}
	
	}
}
#endregion
#region TextPhrase (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: TextPhrase</para>
	/// <para>ID: {A24644F1-7060-46C4-9ACD-B181ACB653F7}</para>
	/// <para>/sitecore/templates/Ignite/Phrases/TextPhrase</para>
	/// </summary>
	[TemplateMapping("{A24644F1-7060-46C4-9ACD-B181ACB653F7}", "InterfaceMap")]
	public partial interface ITextPhrase : ICustomItemWrapper , LM.Model.Templates.Ignite.IPhrase	{		
    	/// <summary>
		/// <para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phrase_t")]
		ITextFieldWrapper Phrase { get; }

    	/// <summary>
		/// <para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phrase")]
 		string PhraseValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Phrases/TextPhrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A24644F1-7060-46C4-9ACD-B181ACB653F7}", typeof(Guid))]
	[TemplateMapping("{A24644F1-7060-46C4-9ACD-B181ACB653F7}", "")]
	public partial class TextPhrase : CustomItemWrapper, ITextPhrase
	{
		private Item _item = null;

		public TextPhrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TextPhrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TextPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TextPhrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase_t")]
		public virtual ITextFieldWrapper Phrase
		{
			get { return GetField<TextFieldWrapper>("Phrase", "phrase_t"); }
		}

		/// <summary><para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase")]
 		public string PhraseValue
		{
					get { return Phrase.Value; }
				}
	
	}
}
#endregion
#region Folder (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Folder</para>
	/// <para>ID: {A87A00B1-E6DB-45AB-8B54-636FEC3B5523}</para>
	/// <para>/sitecore/templates/Common/Folder</para>
	/// </summary>
	[TemplateMapping("{A87A00B1-E6DB-45AB-8B54-636FEC3B5523}", "InterfaceMap")]
	public partial interface IFolder : ICustomItemWrapper 	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Common/Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A87A00B1-E6DB-45AB-8B54-636FEC3B5523}", typeof(Guid))]
	[TemplateMapping("{A87A00B1-E6DB-45AB-8B54-636FEC3B5523}", "")]
	public partial class Folder : CustomItemWrapper, IFolder
	{
		private Item _item = null;

		public Folder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Folder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Folder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Folder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Analytics Tracking (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Analytics Tracking</para>
	/// <para>ID: {B204D501-48C3-4E3F-949E-9D428F1EBBBA}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Analytics Tracking</para>
	/// </summary>
	[TemplateMapping("{B204D501-48C3-4E3F-949E-9D428F1EBBBA}", "InterfaceMap")]
	public partial interface IAnalyticsTracking : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_action_t")]
		ITextFieldWrapper TrackingAction { get; }

    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_action")]
 		string TrackingActionValue { get; }
    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_category_t")]
		ITextFieldWrapper TrackingCategory { get; }

    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_category")]
 		string TrackingCategoryValue { get; }
    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_label_t")]
		ITextFieldWrapper TrackingLabel { get; }

    	/// <summary>
		/// <para>Template: Analytics Tracking</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("tracking_label")]
 		string TrackingLabelValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Analytics Tracking</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{B204D501-48C3-4E3F-949E-9D428F1EBBBA}", typeof(Guid))]
	[TemplateMapping("{B204D501-48C3-4E3F-949E-9D428F1EBBBA}", "")]
	public partial class AnalyticsTracking : CustomItemWrapper, IAnalyticsTracking
	{
		private Item _item = null;

		public AnalyticsTracking(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public AnalyticsTracking(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public AnalyticsTracking(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public AnalyticsTracking(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Analytics Tracking</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
	
	}
}
#endregion
#region Base CTA (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Base CTA</para>
	/// <para>ID: {BB67FE5B-450A-41ED-9743-79B35DA559F2}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Base CTA</para>
	/// </summary>
	[TemplateMapping("{BB67FE5B-450A-41ED-9743-79B35DA559F2}", "InterfaceMap")]
	public partial interface IBaseCTA : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Base CTA</para><para>Field: CTALink</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("cta_link_t")]
		IGeneralLinkFieldWrapper CTALink { get; }

    	/// <summary>
		/// <para>Template: Base CTA</para><para>Field: CTALink</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("cta_link")]
 		string CTALinkValue { get; }
    	/// <summary>
		/// <para>Template: Base CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_text_t")]
		ITextFieldWrapper CTAText { get; }

    	/// <summary>
		/// <para>Template: Base CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_text")]
 		string CTATextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Base CTA</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{BB67FE5B-450A-41ED-9743-79B35DA559F2}", typeof(Guid))]
	[TemplateMapping("{BB67FE5B-450A-41ED-9743-79B35DA559F2}", "")]
	public partial class BaseCTA : CustomItemWrapper, IBaseCTA
	{
		private Item _item = null;

		public BaseCTA(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BaseCTA(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BaseCTA(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BaseCTA(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Base CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link_t")]
		public virtual IGeneralLinkFieldWrapper CTALink
		{
			get { return GetField<GeneralLinkFieldWrapper>("CTA Link", "cta_link_t"); }
		}

		/// <summary><para>Template: Base CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link")]
 		public string CTALinkValue
		{
					get { return CTALink.Value; }
				}
		/// <summary><para>Template: Base CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Base CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
	
	}
}
#endregion
#region OoyalaVideo (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaVideo</para>
	/// <para>ID: {C3B8C43D-AD6B-49E2-9C6E-2FB4B53A966A}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaVideo</para>
	/// </summary>
	[TemplateMapping("{C3B8C43D-AD6B-49E2-9C6E-2FB4B53A966A}", "InterfaceMap")]
	public partial interface IOoyalaVideo : ICustomItemWrapper , LM.Model.Templates.Ignite.IOoyalaMediaElement	{		
    	/// <summary>
		/// <para>Template: OoyalaVideo</para><para>Field: OriginalFileName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("originalfilename_t")]
		ITextFieldWrapper OriginalFileName { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideo</para><para>Field: OriginalFileName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("originalfilename")]
 		string OriginalFileNameValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaVideo</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{C3B8C43D-AD6B-49E2-9C6E-2FB4B53A966A}", typeof(Guid))]
	[TemplateMapping("{C3B8C43D-AD6B-49E2-9C6E-2FB4B53A966A}", "")]
	public partial class OoyalaVideo : CustomItemWrapper, IOoyalaVideo
	{
		private Item _item = null;

		public OoyalaVideo(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaVideo(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaVideo(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaVideo(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
		public virtual ITextFieldWrapper CustomMetadata
		{
			get { return GetField<TextFieldWrapper>("CustomMetadata"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: CustomMetadata</para><para>Data type: Name Value List</para></summary>
 		public string CustomMetadataValue
		{
					get { return CustomMetadata.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper AssetType
		{
			get { return GetField<TextFieldWrapper>("AssetType"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: AssetType</para><para>Data type: ReadOnlyText</para></summary>
 		public string AssetTypeValue
		{
					get { return AssetType.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description_t")]
		public virtual IRichTextFieldWrapper Description
		{
			get { return GetField<RichTextFieldWrapper>("Description", "description_t"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: Description</para><para>Data type: Rich Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
					get { return Description.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper Duration
		{
			get { return GetField<TextFieldWrapper>("Duration"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: Duration</para><para>Data type: ReadOnlyText</para></summary>
 		public string DurationValue
		{
					get { return Duration.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper EmbedCode
		{
			get { return GetField<TextFieldWrapper>("EmbedCode"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: EmbedCode</para><para>Data type: ReadOnlyText</para></summary>
 		public string EmbedCodeValue
		{
					get { return EmbedCode.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream_b")]
		public virtual IBooleanFieldWrapper IsLiveStream
		{
			get { return GetField<BooleanFieldWrapper>("isLiveStream", "islivestream_b"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: IsLiveStream</para><para>Data type: Checkbox</para></summary>
		[IndexField("islivestream")]
 		public bool IsLiveStreamValue
		{
					get { return IsLiveStream.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name_t")]
		public virtual ITextFieldWrapper Name
		{
			get { return GetField<TextFieldWrapper>("Name", "name_t"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name")]
 		public string NameValue
		{
					get { return Name.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player_s")]
		public virtual ILinkFieldWrapper Player
		{
			get { return GetField<LinkFieldWrapper>("Player", "player_s"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: Player</para><para>Data type: Droplink</para></summary>
		[IndexField("player")]
 		public Guid PlayerValue
		{
					get { return Player.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
		public virtual ITextFieldWrapper PreviewImageUrl
		{
			get { return GetField<TextFieldWrapper>("PreviewImageUrl"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: PreviewImageUrl</para><para>Data type: ImagePreview</para></summary>
 		public string PreviewImageUrlValue
		{
					get { return PreviewImageUrl.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status_t")]
		public virtual ITextFieldWrapper Status
		{
			get { return GetField<TextFieldWrapper>("Status", "status_t"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: Status</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("status")]
 		public string StatusValue
		{
					get { return Status.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper CreatedAt
		{
			get { return GetField<TextFieldWrapper>("CreatedAt"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: CreatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string CreatedAtValue
		{
					get { return CreatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper UpdatedAt
		{
			get { return GetField<TextFieldWrapper>("UpdatedAt"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: UpdatedAt</para><para>Data type: ReadOnlyText</para></summary>
 		public string UpdatedAtValue
		{
					get { return UpdatedAt.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist_sm")]
		public virtual IListFieldWrapper LabelsList
		{
			get { return GetField<ListFieldWrapper>("LabelsList", "labelslist_sm"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: LabelsList</para><para>Data type: Multilist</para></summary>
		[IndexField("labelslist")]
 		public IEnumerable<Guid> LabelsListValue
		{
					get { return LabelsList.Value; }
				}
		/// <summary><para>Template: OoyalaVideo</para><para>Field: OriginalFileName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("originalfilename_t")]
		public virtual ITextFieldWrapper OriginalFileName
		{
			get { return GetField<TextFieldWrapper>("OriginalFileName", "originalfilename_t"); }
		}

		/// <summary><para>Template: OoyalaVideo</para><para>Field: OriginalFileName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("originalfilename")]
 		public string OriginalFileNameValue
		{
					get { return OriginalFileName.Value; }
				}
	
	}
}
#endregion
#region OTT Device Settings (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OTT Device Settings</para>
	/// <para>ID: {C9462AF4-18E4-4B2A-902F-72023B5BFD90}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/OTT Device Settings</para>
	/// </summary>
	[TemplateMapping("{C9462AF4-18E4-4B2A-902F-72023B5BFD90}", "InterfaceMap")]
	public partial interface IOTTDeviceSettings : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSettings	{		
    	/// <summary>
		/// <para>Template: OTT Device Settings</para><para>Field: AvailableNow</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("available_now_sm")]
		IListFieldWrapper AvailableNow { get; }

    	/// <summary>
		/// <para>Template: OTT Device Settings</para><para>Field: AvailableNow</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("available_now")]
 		IEnumerable<Guid> AvailableNowValue { get; }
    	/// <summary>
		/// <para>Template: OTT Device Settings</para><para>Field: AvailableSoon</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("available_soon_sm")]
		IListFieldWrapper AvailableSoon { get; }

    	/// <summary>
		/// <para>Template: OTT Device Settings</para><para>Field: AvailableSoon</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("available_soon")]
 		IEnumerable<Guid> AvailableSoonValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/OTT Device Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{C9462AF4-18E4-4B2A-902F-72023B5BFD90}", typeof(Guid))]
	[TemplateMapping("{C9462AF4-18E4-4B2A-902F-72023B5BFD90}", "")]
	public partial class OTTDeviceSettings : CustomItemWrapper, IOTTDeviceSettings
	{
		private Item _item = null;

		public OTTDeviceSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OTTDeviceSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OTTDeviceSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OTTDeviceSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OTT Device Settings</para><para>Field: AvailableNow</para><para>Data type: Multilist</para></summary>
		[IndexField("available_now_sm")]
		public virtual IListFieldWrapper AvailableNow
		{
			get { return GetField<ListFieldWrapper>("Available Now", "available_now_sm"); }
		}

		/// <summary><para>Template: OTT Device Settings</para><para>Field: AvailableNow</para><para>Data type: Multilist</para></summary>
		[IndexField("available_now")]
 		public IEnumerable<Guid> AvailableNowValue
		{
					get { return AvailableNow.Value; }
				}
		/// <summary><para>Template: OTT Device Settings</para><para>Field: AvailableSoon</para><para>Data type: Multilist</para></summary>
		[IndexField("available_soon_sm")]
		public virtual IListFieldWrapper AvailableSoon
		{
			get { return GetField<ListFieldWrapper>("Available Soon", "available_soon_sm"); }
		}

		/// <summary><para>Template: OTT Device Settings</para><para>Field: AvailableSoon</para><para>Data type: Multilist</para></summary>
		[IndexField("available_soon")]
 		public IEnumerable<Guid> AvailableSoonValue
		{
					get { return AvailableSoon.Value; }
				}
	
	}
}
#endregion
#region Ignite Standard Template (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ignite Standard Template</para>
	/// <para>ID: {C99768FE-5EF4-4A9A-A06B-F6F926391940}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Standard Template</para>
	/// </summary>
	[TemplateMapping("{C99768FE-5EF4-4A9A-A06B-F6F926391940}", "InterfaceMap")]
	public partial interface IIgniteStandardTemplate : ICustomItemWrapper 	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Ignite Standard Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{C99768FE-5EF4-4A9A-A06B-F6F926391940}", typeof(Guid))]
	[TemplateMapping("{C99768FE-5EF4-4A9A-A06B-F6F926391940}", "")]
	public partial class IgniteStandardTemplate : CustomItemWrapper, IIgniteStandardTemplate
	{
		private Item _item = null;

		public IgniteStandardTemplate(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public IgniteStandardTemplate(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public IgniteStandardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public IgniteStandardTemplate(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Navigation Link (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Navigation Link</para>
	/// <para>ID: {CD1AE917-5B3E-4731-BF52-033210EA5941}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Navigation Link</para>
	/// </summary>
	[TemplateMapping("{CD1AE917-5B3E-4731-BF52-033210EA5941}", "InterfaceMap")]
	public partial interface INavigationLink : ICustomItemWrapper , LM.Model.Templates.PokerCentral.INavigation	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Navigation Link</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{CD1AE917-5B3E-4731-BF52-033210EA5941}", typeof(Guid))]
	[TemplateMapping("{CD1AE917-5B3E-4731-BF52-033210EA5941}", "")]
	public partial class NavigationLink : CustomItemWrapper, INavigationLink
	{
		private Item _item = null;

		public NavigationLink(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public NavigationLink(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public NavigationLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public NavigationLink(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
	
	}
}
#endregion
#region Category (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Category</para>
	/// <para>ID: {D1478FBE-7D13-4213-86DE-660609C15CCC}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Media/Category</para>
	/// </summary>
	[TemplateMapping("{D1478FBE-7D13-4213-86DE-660609C15CCC}", "InterfaceMap")]
	public partial interface ICategory : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Category</para><para>Field: CategoryName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("category_name_t")]
		ITextFieldWrapper CategoryName { get; }

    	/// <summary>
		/// <para>Template: Category</para><para>Field: CategoryName</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("category_name")]
 		string CategoryNameValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Media/Category</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D1478FBE-7D13-4213-86DE-660609C15CCC}", typeof(Guid))]
	[TemplateMapping("{D1478FBE-7D13-4213-86DE-660609C15CCC}", "")]
	public partial class Category : CustomItemWrapper, ICategory
	{
		private Item _item = null;

		public Category(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Category(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Category(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Category(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Category</para><para>Field: CategoryName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("category_name_t")]
		public virtual ITextFieldWrapper CategoryName
		{
			get { return GetField<TextFieldWrapper>("Category Name", "category_name_t"); }
		}

		/// <summary><para>Template: Category</para><para>Field: CategoryName</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("category_name")]
 		public string CategoryNameValue
		{
					get { return CategoryName.Value; }
				}
	
	}
}
#endregion
#region In The News Link (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: In The News Link</para>
	/// <para>ID: {D2BAFDB7-A961-4B1C-A534-1D705D5AC05F}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Media/In The News Link</para>
	/// </summary>
	[TemplateMapping("{D2BAFDB7-A961-4B1C-A534-1D705D5AC05F}", "InterfaceMap")]
	public partial interface IInTheNewsLink : ICustomItemWrapper , LM.Model.Templates.PokerCentral.INavigation	{		
    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("article_title_t")]
		ITextFieldWrapper ArticleTitle { get; }

    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("article_title")]
 		string ArticleTitleValue { get; }
    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: Categories</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("categories_sm")]
		IListFieldWrapper Categories { get; }

    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: Categories</para><para>Data type: Multilist</para>
        /// </summary>
		[IndexField("categories")]
 		IEnumerable<Guid> CategoriesValue { get; }
    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: DatePublished</para><para>Data type: Date</para>
        /// </summary>
		[IndexField("date_published_tdt")]
		IDateTimeFieldWrapper DatePublished { get; }

    	/// <summary>
		/// <para>Template: In The News Link</para><para>Field: DatePublished</para><para>Data type: Date</para>
        /// </summary>
		[IndexField("date_published")]
 		DateTime DatePublishedValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Media/In The News Link</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D2BAFDB7-A961-4B1C-A534-1D705D5AC05F}", typeof(Guid))]
	[TemplateMapping("{D2BAFDB7-A961-4B1C-A534-1D705D5AC05F}", "")]
	public partial class InTheNewsLink : CustomItemWrapper, IInTheNewsLink
	{
		private Item _item = null;

		public InTheNewsLink(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public InTheNewsLink(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public InTheNewsLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public InTheNewsLink(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: In The News Link</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("article_title_t")]
		public virtual ITextFieldWrapper ArticleTitle
		{
			get { return GetField<TextFieldWrapper>("Article Title", "article_title_t"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("article_title")]
 		public string ArticleTitleValue
		{
					get { return ArticleTitle.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: Categories</para><para>Data type: Multilist</para></summary>
		[IndexField("categories_sm")]
		public virtual IListFieldWrapper Categories
		{
			get { return GetField<ListFieldWrapper>("Categories", "categories_sm"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: Categories</para><para>Data type: Multilist</para></summary>
		[IndexField("categories")]
 		public IEnumerable<Guid> CategoriesValue
		{
					get { return Categories.Value; }
				}
		/// <summary><para>Template: In The News Link</para><para>Field: DatePublished</para><para>Data type: Date</para></summary>
		[IndexField("date_published_tdt")]
		public virtual IDateTimeFieldWrapper DatePublished
		{
			get { return GetField<DateTimeFieldWrapper>("Date Published", "date_published_tdt"); }
		}

		/// <summary><para>Template: In The News Link</para><para>Field: DatePublished</para><para>Data type: Date</para></summary>
		[IndexField("date_published")]
 		public DateTime DatePublishedValue
		{
					get { return DatePublished.Value; }
				}
	
	}
}
#endregion
#region CTA Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: CTA Folder</para>
	/// <para>ID: {D59ADF75-E047-4BBF-8E76-8B9DD733C1EC}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/CTA Folder</para>
	/// </summary>
	[TemplateMapping("{D59ADF75-E047-4BBF-8E76-8B9DD733C1EC}", "InterfaceMap")]
	public partial interface ICTAFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/CTA Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D59ADF75-E047-4BBF-8E76-8B9DD733C1EC}", typeof(Guid))]
	[TemplateMapping("{D59ADF75-E047-4BBF-8E76-8B9DD733C1EC}", "")]
	public partial class CTAFolder : CustomItemWrapper, ICTAFolder
	{
		private Item _item = null;

		public CTAFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CTAFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CTAFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CTAFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Ignite Folder (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ignite Folder</para>
	/// <para>ID: {D9AFFFBE-D870-4278-B4FB-825D12201C4D}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Folder</para>
	/// </summary>
	[TemplateMapping("{D9AFFFBE-D870-4278-B4FB-825D12201C4D}", "InterfaceMap")]
	public partial interface IIgniteFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IFolder, LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Ignite Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D9AFFFBE-D870-4278-B4FB-825D12201C4D}", typeof(Guid))]
	[TemplateMapping("{D9AFFFBE-D870-4278-B4FB-825D12201C4D}", "")]
	public partial class IgniteFolder : CustomItemWrapper, IIgniteFolder
	{
		private Item _item = null;

		public IgniteFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public IgniteFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public IgniteFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public IgniteFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Phrase (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Phrase</para>
	/// <para>ID: {DC9FA523-7F26-44F7-96A5-E4FF9B64658A}</para>
	/// <para>/sitecore/templates/Ignite/Phrases/Phrase</para>
	/// </summary>
	[TemplateMapping("{DC9FA523-7F26-44F7-96A5-E4FF9B64658A}", "InterfaceMap")]
	public partial interface IPhrase : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Phrases/Phrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{DC9FA523-7F26-44F7-96A5-E4FF9B64658A}", typeof(Guid))]
	[TemplateMapping("{DC9FA523-7F26-44F7-96A5-E4FF9B64658A}", "")]
	public partial class Phrase : CustomItemWrapper, IPhrase
	{
		private Item _item = null;

		public Phrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Phrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Phrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Phrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Ignite Rendering Parameters (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ignite Rendering Parameters</para>
	/// <para>ID: {E13DB450-F493-42D5-B1C1-536A57AED2A6}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{E13DB450-F493-42D5-B1C1-536A57AED2A6}", "InterfaceRenderingParameter")]
	public partial interface IIgniteRenderingParameters : IRenderingParameterWrapper 	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/Ignite/Ignite Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E13DB450-F493-42D5-B1C1-536A57AED2A6}", typeof(Guid))]
	[TemplateMapping("{E13DB450-F493-42D5-B1C1-536A57AED2A6}", "RenderingParameter")]
	public partial class IgniteRenderingParameters : RenderingParameterWrapper, IIgniteRenderingParameters
	{
		public IgniteRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

	
	}
}
#endregion
#region Download Link Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Download Link Folder</para>
	/// <para>ID: {E4FBE316-45CC-47AC-896B-1F51F59D7CCE}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Download Link Folder</para>
	/// </summary>
	[TemplateMapping("{E4FBE316-45CC-47AC-896B-1F51F59D7CCE}", "InterfaceMap")]
	public partial interface IDownloadLinkFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
    	/// <summary>
		/// <para>Template: Download Link Folder</para><para>Field: LinkFile</para><para>Data type: File</para>
        /// </summary>
		IFileFieldWrapper LinkFile { get; }
 		string LinkFileValue { get; }
    	/// <summary>
		/// <para>Template: Download Link Folder</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title_t")]
		ITextFieldWrapper Title { get; }

    	/// <summary>
		/// <para>Template: Download Link Folder</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title")]
 		string TitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Download Link Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E4FBE316-45CC-47AC-896B-1F51F59D7CCE}", typeof(Guid))]
	[TemplateMapping("{E4FBE316-45CC-47AC-896B-1F51F59D7CCE}", "")]
	public partial class DownloadLinkFolder : CustomItemWrapper, IDownloadLinkFolder
	{
		private Item _item = null;

		public DownloadLinkFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public DownloadLinkFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public DownloadLinkFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public DownloadLinkFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Download Link Folder</para><para>Field: LinkFile</para><para>Data type: File</para></summary>
		public virtual IFileFieldWrapper LinkFile
		{
			get { return GetField<FileFieldWrapper>("Link File"); }
		}

		/// <summary><para>Template: Download Link Folder</para><para>Field: LinkFile</para><para>Data type: File</para></summary>
 		public string LinkFileValue
		{
					get { return LinkFile.Value; }
				}
		/// <summary><para>Template: Download Link Folder</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Download Link Folder</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
					get { return Title.Value; }
				}
	
	}
}
#endregion
#region Featured Slider Rendering Parameters (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Featured Slider Rendering Parameters</para>
	/// <para>ID: {E50781A9-7A1F-4C69-85A0-08E66FECF380}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Rendering Parameters/Featured Slider Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{E50781A9-7A1F-4C69-85A0-08E66FECF380}", "InterfaceRenderingParameter")]
	public partial interface IFeaturedSliderRenderingParameters : IRenderingParameterWrapper , LM.Model.Templates.Ignite.IIgniteRenderingParameters	{		
    	/// <summary>
		/// <para>Template: Featured Slider Rendering Parameters</para><para>Field: ShareLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper ShareLabel { get; }
 		Guid ShareLabelValue { get; }
    	/// <summary>
		/// <para>Template: Featured Slider Rendering Parameters</para><para>Field: MaxSlides</para><para>Data type: Single-Line Text</para>
        /// </summary>
		ITextFieldWrapper MaxSlides { get; }
 		string MaxSlidesValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Rendering Parameters/Featured Slider Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E50781A9-7A1F-4C69-85A0-08E66FECF380}", typeof(Guid))]
	[TemplateMapping("{E50781A9-7A1F-4C69-85A0-08E66FECF380}", "RenderingParameter")]
	public partial class FeaturedSliderRenderingParameters : RenderingParameterWrapper, IFeaturedSliderRenderingParameters
	{
		public FeaturedSliderRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Featured Slider Rendering Parameters</para><para>Field: ShareLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper ShareLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Share Label", "droptree"); }
		}

		/// <summary><para>Template: Featured Slider Rendering Parameters</para><para>Field: ShareLabel</para><para>Data type: Droptree</para></summary>
 		public Guid ShareLabelValue
		{
					get { return ShareLabel.Value; }
				}
		/// <summary><para>Template: Featured Slider Rendering Parameters</para><para>Field: MaxSlides</para><para>Data type: Single-Line Text</para></summary>
		public virtual ITextFieldWrapper MaxSlides
		{
			get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("Max Slides", "single-line text"); }
		}

		/// <summary><para>Template: Featured Slider Rendering Parameters</para><para>Field: MaxSlides</para><para>Data type: Single-Line Text</para></summary>
 		public string MaxSlidesValue
		{
					get { return MaxSlides.Value; }
				}
	
	}
}
#endregion
#region Devices Landing Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Devices Landing Page</para>
	/// <para>ID: {E6D7F99F-0CF3-4056-AC6E-8225C3CA8BFB}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Devices/Devices Landing Page</para>
	/// </summary>
	[TemplateMapping("{E6D7F99F-0CF3-4056-AC6E-8225C3CA8BFB}", "InterfaceMap")]
	public partial interface IDevicesLandingPage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.ILandingPage	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Devices/Devices Landing Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E6D7F99F-0CF3-4056-AC6E-8225C3CA8BFB}", typeof(Guid))]
	[TemplateMapping("{E6D7F99F-0CF3-4056-AC6E-8225C3CA8BFB}", "")]
	public partial class DevicesLandingPage : CustomItemWrapper, IDevicesLandingPage
	{
		private Item _item = null;

		public DevicesLandingPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public DevicesLandingPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public DevicesLandingPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public DevicesLandingPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: Devices Landing Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Devices Landing Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region Error Settings (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Error Settings</para>
	/// <para>ID: {E6E5348D-7EAF-43A0-BC84-ECA4258CBB5F}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Error Settings</para>
	/// </summary>
	[TemplateMapping("{E6E5348D-7EAF-43A0-BC84-ECA4258CBB5F}", "InterfaceMap")]
	public partial interface IErrorSettings : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseSettings	{		
    	/// <summary>
		/// <para>Template: Error Settings</para><para>Field: Site404Page</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("site_404_page_s")]
		ILinkFieldWrapper Site404Page { get; }

    	/// <summary>
		/// <para>Template: Error Settings</para><para>Field: Site404Page</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("site_404_page")]
 		Guid Site404PageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Error Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E6E5348D-7EAF-43A0-BC84-ECA4258CBB5F}", typeof(Guid))]
	[TemplateMapping("{E6E5348D-7EAF-43A0-BC84-ECA4258CBB5F}", "")]
	public partial class ErrorSettings : CustomItemWrapper, IErrorSettings
	{
		private Item _item = null;

		public ErrorSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ErrorSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ErrorSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ErrorSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Error Settings</para><para>Field: Site404Page</para><para>Data type: Droptree</para></summary>
		[IndexField("site_404_page_s")]
		public virtual ILinkFieldWrapper Site404Page
		{
			get { return GetField<LinkFieldWrapper>("Site 404 Page", "site_404_page_s"); }
		}

		/// <summary><para>Template: Error Settings</para><para>Field: Site404Page</para><para>Data type: Droptree</para></summary>
		[IndexField("site_404_page")]
 		public Guid Site404PageValue
		{
					get { return Site404Page.Value; }
				}
	
	}
}
#endregion
#region Lookup Item (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Lookup Item</para>
	/// <para>ID: {E81F2FC8-28BE-4D75-B6B5-194807D3DA00}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Lookup Item</para>
	/// </summary>
	[TemplateMapping("{E81F2FC8-28BE-4D75-B6B5-194807D3DA00}", "InterfaceMap")]
	public partial interface ILookupItem : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Lookup Item</para><para>Field: TextValue</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("text_value_t")]
		ITextFieldWrapper TextValue { get; }

    	/// <summary>
		/// <para>Template: Lookup Item</para><para>Field: TextValue</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("text_value")]
 		string TextValueValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Lookup Item</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E81F2FC8-28BE-4D75-B6B5-194807D3DA00}", typeof(Guid))]
	[TemplateMapping("{E81F2FC8-28BE-4D75-B6B5-194807D3DA00}", "")]
	public partial class LookupItem : CustomItemWrapper, ILookupItem
	{
		private Item _item = null;

		public LookupItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public LookupItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public LookupItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public LookupItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Lookup Item</para><para>Field: TextValue</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("text_value_t")]
		public virtual ITextFieldWrapper TextValue
		{
			get { return GetField<TextFieldWrapper>("Text Value", "text_value_t"); }
		}

		/// <summary><para>Template: Lookup Item</para><para>Field: TextValue</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("text_value")]
 		public string TextValueValue
		{
					get { return TextValue.Value; }
				}
	
	}
}
#endregion
#region Content (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content</para>
	/// <para>ID: {E9828587-24E6-478B-8778-C36FCC93C062}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Content/Content</para>
	/// </summary>
	[TemplateMapping("{E9828587-24E6-478B-8778-C36FCC93C062}", "InterfaceMap")]
	public partial interface IContent : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: Content</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("content_body_t")]
		IRichTextFieldWrapper ContentBody { get; }

    	/// <summary>
		/// <para>Template: Content</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("content_body")]
 		string ContentBodyValue { get; }
    	/// <summary>
		/// <para>Template: Content</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("page_summary_t")]
		ITextFieldWrapper PageSummary { get; }

    	/// <summary>
		/// <para>Template: Content</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("page_summary")]
 		string PageSummaryValue { get; }
    	/// <summary>
		/// <para>Template: Content</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("page_title_t")]
		ITextFieldWrapper PageTitle { get; }

    	/// <summary>
		/// <para>Template: Content</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("page_title")]
 		string PageTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Content/Content</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E9828587-24E6-478B-8778-C36FCC93C062}", typeof(Guid))]
	[TemplateMapping("{E9828587-24E6-478B-8778-C36FCC93C062}", "")]
	public partial class Content : CustomItemWrapper, IContent
	{
		private Item _item = null;

		public Content(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Content(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Content(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Content(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Content</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Content</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Content</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Content</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Content</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
	
	}
}
#endregion
#region Press Release (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Press Release</para>
	/// <para>ID: {EA67B4DD-2B7A-4CE4-8986-900E058FCA4C}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Media/Press Release</para>
	/// </summary>
	[TemplateMapping("{EA67B4DD-2B7A-4CE4-8986-900E058FCA4C}", "InterfaceMap")]
	public partial interface IPressRelease : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IInTheNewsLink, LM.Model.Templates.PokerCentral.IContentPage	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Media/Press Release</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{EA67B4DD-2B7A-4CE4-8986-900E058FCA4C}", typeof(Guid))]
	[TemplateMapping("{EA67B4DD-2B7A-4CE4-8986-900E058FCA4C}", "")]
	public partial class PressRelease : CustomItemWrapper, IPressRelease
	{
		private Item _item = null;

		public PressRelease(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public PressRelease(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public PressRelease(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public PressRelease(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Press Release</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("article_title_t")]
		public virtual ITextFieldWrapper ArticleTitle
		{
			get { return GetField<TextFieldWrapper>("Article Title", "article_title_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: ArticleTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("article_title")]
 		public string ArticleTitleValue
		{
					get { return ArticleTitle.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: Categories</para><para>Data type: Multilist</para></summary>
		[IndexField("categories_sm")]
		public virtual IListFieldWrapper Categories
		{
			get { return GetField<ListFieldWrapper>("Categories", "categories_sm"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: Categories</para><para>Data type: Multilist</para></summary>
		[IndexField("categories")]
 		public IEnumerable<Guid> CategoriesValue
		{
					get { return Categories.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: DatePublished</para><para>Data type: Date</para></summary>
		[IndexField("date_published_tdt")]
		public virtual IDateTimeFieldWrapper DatePublished
		{
			get { return GetField<DateTimeFieldWrapper>("Date Published", "date_published_tdt"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: DatePublished</para><para>Data type: Date</para></summary>
		[IndexField("date_published")]
 		public DateTime DatePublishedValue
		{
					get { return DatePublished.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Press Release</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Press Release</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
	
	}
}
#endregion
#region Countdown Clock Rendering Parameters (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
	using Fortis.Model.RenderingParameters;
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Countdown Clock Rendering Parameters</para>
	/// <para>ID: {EBC16B18-5A52-4EE6-8545-33689942C979}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Rendering Parameters/Countdown Clock Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{EBC16B18-5A52-4EE6-8545-33689942C979}", "InterfaceRenderingParameter")]
	public partial interface ICountdownClockRenderingParameters : IRenderingParameterWrapper , LM.Model.Templates.Ignite.IIgniteRenderingParameters	{		
    	/// <summary>
		/// <para>Template: Countdown Clock Rendering Parameters</para><para>Field: BeginsInLabel</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper BeginsInLabel { get; }
 		Guid BeginsInLabelValue { get; }
    	/// <summary>
		/// <para>Template: Countdown Clock Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper TitleText { get; }
 		Guid TitleTextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Rendering Parameters/Countdown Clock Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{EBC16B18-5A52-4EE6-8545-33689942C979}", typeof(Guid))]
	[TemplateMapping("{EBC16B18-5A52-4EE6-8545-33689942C979}", "RenderingParameter")]
	public partial class CountdownClockRenderingParameters : RenderingParameterWrapper, ICountdownClockRenderingParameters
	{
		public CountdownClockRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Countdown Clock Rendering Parameters</para><para>Field: BeginsInLabel</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper BeginsInLabel
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Begins In Label", "droptree"); }
		}

		/// <summary><para>Template: Countdown Clock Rendering Parameters</para><para>Field: BeginsInLabel</para><para>Data type: Droptree</para></summary>
 		public Guid BeginsInLabelValue
		{
					get { return BeginsInLabel.Value; }
				}
		/// <summary><para>Template: Countdown Clock Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper TitleText
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Title Text", "droptree"); }
		}

		/// <summary><para>Template: Countdown Clock Rendering Parameters</para><para>Field: TitleText</para><para>Data type: Droptree</para></summary>
 		public Guid TitleTextValue
		{
					get { return TitleText.Value; }
				}
	
	}
}
#endregion
#region Menu Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Menu Folder</para>
	/// <para>ID: {EBDC7EB4-C748-46DB-BBE8-E7996867BF49}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Navigation/Menu Folder</para>
	/// </summary>
	[TemplateMapping("{EBDC7EB4-C748-46DB-BBE8-E7996867BF49}", "InterfaceMap")]
	public partial interface IMenuFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Navigation/Menu Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{EBDC7EB4-C748-46DB-BBE8-E7996867BF49}", typeof(Guid))]
	[TemplateMapping("{EBDC7EB4-C748-46DB-BBE8-E7996867BF49}", "")]
	public partial class MenuFolder : CustomItemWrapper, IMenuFolder
	{
		private Item _item = null;

		public MenuFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public MenuFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public MenuFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public MenuFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region CTA Row (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: CTA Row</para>
	/// <para>ID: {F21CA029-879E-4CD9-A5DB-C5D2D66DAAC5}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/CTA Row</para>
	/// </summary>
	[TemplateMapping("{F21CA029-879E-4CD9-A5DB-C5D2D66DAAC5}", "InterfaceMap")]
	public partial interface ICTARow : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteStandardTemplate	{		
    	/// <summary>
		/// <para>Template: CTA Row</para><para>Field: SelectedCTAs</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("selected_ctas_sm")]
		IListFieldWrapper SelectedCTAs { get; }

    	/// <summary>
		/// <para>Template: CTA Row</para><para>Field: SelectedCTAs</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("selected_ctas")]
 		IEnumerable<Guid> SelectedCTAsValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/CTA Row</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F21CA029-879E-4CD9-A5DB-C5D2D66DAAC5}", typeof(Guid))]
	[TemplateMapping("{F21CA029-879E-4CD9-A5DB-C5D2D66DAAC5}", "")]
	public partial class CTARow : CustomItemWrapper, ICTARow
	{
		private Item _item = null;

		public CTARow(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CTARow(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CTARow(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CTARow(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: CTA Row</para><para>Field: SelectedCTAs</para><para>Data type: TreelistEx</para></summary>
		[IndexField("selected_ctas_sm")]
		public virtual IListFieldWrapper SelectedCTAs
		{
			get { return GetField<ListFieldWrapper>("Selected CTAs", "selected_ctas_sm"); }
		}

		/// <summary><para>Template: CTA Row</para><para>Field: SelectedCTAs</para><para>Data type: TreelistEx</para></summary>
		[IndexField("selected_ctas")]
 		public IEnumerable<Guid> SelectedCTAsValue
		{
					get { return SelectedCTAs.Value; }
				}
	
	}
}
#endregion
#region Sponsored Content Page (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Sponsored Content Page</para>
	/// <para>ID: {F5DF1535-9CCE-4598-ABD1-82E79977BB44}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/Page Types/Sponsored Content Page</para>
	/// </summary>
	[TemplateMapping("{F5DF1535-9CCE-4598-ABD1-82E79977BB44}", "InterfaceMap")]
	public partial interface ISponsoredContentPage : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IContentPage, LM.Model.Templates.PokerCentral.ISponsors	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/Page Types/Sponsored Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F5DF1535-9CCE-4598-ABD1-82E79977BB44}", typeof(Guid))]
	[TemplateMapping("{F5DF1535-9CCE-4598-ABD1-82E79977BB44}", "")]
	public partial class SponsoredContentPage : CustomItemWrapper, ISponsoredContentPage
	{
		private Item _item = null;

		public SponsoredContentPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SponsoredContentPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SponsoredContentPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SponsoredContentPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu_b")]
		public virtual IBooleanFieldWrapper HideFromMenu
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Menu", "hide_from_menu_b"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: HideFromMenu</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_menu")]
 		public bool HideFromMenuValue
		{
					get { return HideFromMenu.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
					get { return NavigationTitle.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url_t")]
		public virtual IGeneralLinkFieldWrapper NavigationUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Navigation Url", "navigation_url_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: NavigationUrl</para><para>Data type: General Link</para></summary>
		[IndexField("navigation_url")]
 		public string NavigationUrlValue
		{
					get { return NavigationUrl.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action_t")]
		public virtual ITextFieldWrapper TrackingAction
		{
			get { return GetField<TextFieldWrapper>("Tracking Action", "tracking_action_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingAction</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_action")]
 		public string TrackingActionValue
		{
					get { return TrackingAction.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category_t")]
		public virtual ITextFieldWrapper TrackingCategory
		{
			get { return GetField<TextFieldWrapper>("Tracking Category", "tracking_category_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingCategory</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_category")]
 		public string TrackingCategoryValue
		{
					get { return TrackingCategory.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label_t")]
		public virtual ITextFieldWrapper TrackingLabel
		{
			get { return GetField<TextFieldWrapper>("Tracking Label", "tracking_label_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: TrackingLabel</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("tracking_label")]
 		public string TrackingLabelValue
		{
					get { return TrackingLabel.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body_t")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
 		public string ContentBodyValue
		{
					get { return ContentBody.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary_t")]
		public virtual ITextFieldWrapper PageSummary
		{
			get { return GetField<TextFieldWrapper>("Page Summary", "page_summary_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
 		public string PageSummaryValue
		{
					get { return PageSummary.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
					get { return PageTitle.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url_t")]
		public virtual IGeneralLinkFieldWrapper MetaCanonicalUrl
		{
			get { return GetField<GeneralLinkFieldWrapper>("Meta Canonical Url", "meta_canonical_url_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaCanonicalUrl</para><para>Data type: General Link</para></summary>
		[IndexField("meta_canonical_url")]
 		public string MetaCanonicalUrlValue
		{
					get { return MetaCanonicalUrl.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description_t")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaDescription</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("meta_description")]
 		public string MetaDescriptionValue
		{
					get { return MetaDescription.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper MetaImage
		{
			get { return GetField<ImageFieldWrapper>("Meta Image"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaImage</para><para>Data type: Image</para></summary>
 		public string MetaImageValue
		{
					get { return MetaImage.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords_t")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
 		public string MetaKeywordsValue
		{
					get { return MetaKeywords.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title_t")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title_t"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
 		public string MetaTitleValue
		{
					get { return MetaTitle.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap_b")]
		public virtual IBooleanFieldWrapper HideFromSitemap
		{
			get { return GetField<BooleanFieldWrapper>("Hide from Sitemap", "hide_from_sitemap_b"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: HideFromSitemap</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_sitemap")]
 		public bool HideFromSitemapValue
		{
					get { return HideFromSitemap.Value; }
				}
		/// <summary><para>Template: Sponsored Content Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper SponsoredBackground
		{
			get { return GetField<ImageFieldWrapper>("Sponsored Background"); }
		}

		/// <summary><para>Template: Sponsored Content Page</para><para>Field: SponsoredBackground</para><para>Data type: Image</para></summary>
 		public string SponsoredBackgroundValue
		{
					get { return SponsoredBackground.Value; }
				}
	
	}
}
#endregion
#region OoyalaVideoPlayer (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaVideoPlayer</para>
	/// <para>ID: {FA102033-8863-43C1-9B86-96A0E345B6CA}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaVideoPlayer</para>
	/// </summary>
	[TemplateMapping("{FA102033-8863-43C1-9B86-96A0E345B6CA}", "InterfaceMap")]
	public partial interface IOoyalaVideoPlayer : ICustomItemWrapper 	{		
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: Parameters</para><para>Data type: Name Value List</para>
        /// </summary>
		ITextFieldWrapper Parameters { get; }
 		string ParametersValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: AccentColor</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accentcolor_t")]
		ITextFieldWrapper AccentColor { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: AccentColor</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accentcolor")]
 		string AccentColorValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: EnableErrorScreen</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("enableerrorscreen_b")]
		IBooleanFieldWrapper EnableErrorScreen { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: EnableErrorScreen</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("enableerrorscreen")]
 		bool EnableErrorScreenValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowAdCountdown</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showadcountdown_b")]
		IBooleanFieldWrapper ShowAdCountdown { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowAdCountdown</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showadcountdown")]
 		bool ShowAdCountdownValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowBitrateButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showbitratebutton_b")]
		IBooleanFieldWrapper ShowBitrateButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowBitrateButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showbitratebutton")]
 		bool ShowBitrateButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowChannelButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showchannelbutton_b")]
		IBooleanFieldWrapper ShowChannelButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowChannelButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showchannelbutton")]
 		bool ShowChannelButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowEmbedButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showembedbutton_b")]
		IBooleanFieldWrapper ShowEmbedButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowEmbedButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showembedbutton")]
 		bool ShowEmbedButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowEndScreenReplayButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showendscreenreplaybutton_b")]
		IBooleanFieldWrapper ShowEndScreenReplayButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowEndScreenReplayButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showendscreenreplaybutton")]
 		bool ShowEndScreenReplayButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfobutton_b")]
		IBooleanFieldWrapper ShowInfoButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfobutton")]
 		bool ShowInfoButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenDescription</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreendescription_b")]
		IBooleanFieldWrapper ShowInfoScreenDescription { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenDescription</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreendescription")]
 		bool ShowInfoScreenDescriptionValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenHomepageLink</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreenhomepagelink_b")]
		IBooleanFieldWrapper ShowInfoScreenHomepageLink { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenHomepageLink</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreenhomepagelink")]
 		bool ShowInfoScreenHomepageLinkValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenTitle</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreentitle_b")]
		IBooleanFieldWrapper ShowInfoScreenTitle { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenTitle</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showinfoscreentitle")]
 		bool ShowInfoScreenTitleValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowShareButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showsharebutton_b")]
		IBooleanFieldWrapper ShowShareButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowShareButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showsharebutton")]
 		bool ShowShareButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowVolumeButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showvolumebutton_b")]
		IBooleanFieldWrapper ShowVolumeButton { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ShowVolumeButton</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("showvolumebutton")]
 		bool ShowVolumeButtonValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: BufferOnPause</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("bufferonpause_b")]
		IBooleanFieldWrapper BufferOnPause { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: BufferOnPause</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("bufferonpause")]
 		bool BufferOnPauseValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: DefaultLanguage</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("defaultlanguage_t")]
		ITextFieldWrapper DefaultLanguage { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: DefaultLanguage</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("defaultlanguage")]
 		string DefaultLanguageValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ID</para><para>Data type: ReadOnlyText</para>
        /// </summary>
		ITextFieldWrapper ID { get; }
 		string IDValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: IsDefault</para><para>Data type: ReadOnlyCheckBox</para>
        /// </summary>
		ITextFieldWrapper IsDefault { get; }
 		string IsDefaultValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name_t")]
		ITextFieldWrapper Name { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: Name</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("name")]
 		string NameValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ProviderHomepageUrl</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("providerhomepageurl_t")]
		ITextFieldWrapper ProviderHomepageUrl { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ProviderHomepageUrl</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("providerhomepageurl")]
 		string ProviderHomepageUrlValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: AlwaysShow</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("alwaysshow_b")]
		IBooleanFieldWrapper AlwaysShow { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: AlwaysShow</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("alwaysshow")]
 		bool AlwaysShowValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ScrubberImageUrl</para><para>Data type: ImagePreview</para>
        /// </summary>
		ITextFieldWrapper ScrubberImageUrl { get; }
 		string ScrubberImageUrlValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: DiggSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("diggsharing_b")]
		IBooleanFieldWrapper DiggSharing { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: DiggSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("diggsharing")]
 		bool DiggSharingValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: EmailSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("emailsharing_b")]
		IBooleanFieldWrapper EmailSharing { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: EmailSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("emailsharing")]
 		bool EmailSharingValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: FacebookSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("facebooksharing_b")]
		IBooleanFieldWrapper FacebookSharing { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: FacebookSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("facebooksharing")]
 		bool FacebookSharingValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: TwitterSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("twittersharing_b")]
		IBooleanFieldWrapper TwitterSharing { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: TwitterSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("twittersharing")]
 		bool TwitterSharingValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: UrlSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("urlsharing_b")]
		IBooleanFieldWrapper UrlSharing { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: UrlSharing</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("urlsharing")]
 		bool UrlSharingValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: Alpha</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("alpha_t")]
		ITextFieldWrapper Alpha { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: Alpha</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("alpha")]
 		string AlphaValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ClickUrl</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("clickurl_t")]
		ITextFieldWrapper ClickUrl { get; }

    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: ClickUrl</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("clickurl")]
 		string ClickUrlValue { get; }
    	/// <summary>
		/// <para>Template: OoyalaVideoPlayer</para><para>Field: WatermarkImageUrl</para><para>Data type: ImagePreview</para>
        /// </summary>
		ITextFieldWrapper WatermarkImageUrl { get; }
 		string WatermarkImageUrlValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaVideoPlayer</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FA102033-8863-43C1-9B86-96A0E345B6CA}", typeof(Guid))]
	[TemplateMapping("{FA102033-8863-43C1-9B86-96A0E345B6CA}", "")]
	public partial class OoyalaVideoPlayer : CustomItemWrapper, IOoyalaVideoPlayer
	{
		private Item _item = null;

		public OoyalaVideoPlayer(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaVideoPlayer(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaVideoPlayer(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaVideoPlayer(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Parameters</para><para>Data type: Name Value List</para></summary>
		public virtual ITextFieldWrapper Parameters
		{
			get { return GetField<TextFieldWrapper>("Parameters"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Parameters</para><para>Data type: Name Value List</para></summary>
 		public string ParametersValue
		{
					get { return Parameters.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: AccentColor</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("accentcolor_t")]
		public virtual ITextFieldWrapper AccentColor
		{
			get { return GetField<TextFieldWrapper>("AccentColor", "accentcolor_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: AccentColor</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("accentcolor")]
 		public string AccentColorValue
		{
					get { return AccentColor.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: EnableErrorScreen</para><para>Data type: Checkbox</para></summary>
		[IndexField("enableerrorscreen_b")]
		public virtual IBooleanFieldWrapper EnableErrorScreen
		{
			get { return GetField<BooleanFieldWrapper>("EnableErrorScreen", "enableerrorscreen_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: EnableErrorScreen</para><para>Data type: Checkbox</para></summary>
		[IndexField("enableerrorscreen")]
 		public bool EnableErrorScreenValue
		{
					get { return EnableErrorScreen.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowAdCountdown</para><para>Data type: Checkbox</para></summary>
		[IndexField("showadcountdown_b")]
		public virtual IBooleanFieldWrapper ShowAdCountdown
		{
			get { return GetField<BooleanFieldWrapper>("ShowAdCountdown", "showadcountdown_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowAdCountdown</para><para>Data type: Checkbox</para></summary>
		[IndexField("showadcountdown")]
 		public bool ShowAdCountdownValue
		{
					get { return ShowAdCountdown.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowBitrateButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showbitratebutton_b")]
		public virtual IBooleanFieldWrapper ShowBitrateButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowBitrateButton", "showbitratebutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowBitrateButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showbitratebutton")]
 		public bool ShowBitrateButtonValue
		{
					get { return ShowBitrateButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowChannelButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showchannelbutton_b")]
		public virtual IBooleanFieldWrapper ShowChannelButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowChannelButton", "showchannelbutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowChannelButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showchannelbutton")]
 		public bool ShowChannelButtonValue
		{
					get { return ShowChannelButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowEmbedButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showembedbutton_b")]
		public virtual IBooleanFieldWrapper ShowEmbedButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowEmbedButton", "showembedbutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowEmbedButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showembedbutton")]
 		public bool ShowEmbedButtonValue
		{
					get { return ShowEmbedButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowEndScreenReplayButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showendscreenreplaybutton_b")]
		public virtual IBooleanFieldWrapper ShowEndScreenReplayButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowEndScreenReplayButton", "showendscreenreplaybutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowEndScreenReplayButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showendscreenreplaybutton")]
 		public bool ShowEndScreenReplayButtonValue
		{
					get { return ShowEndScreenReplayButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfobutton_b")]
		public virtual IBooleanFieldWrapper ShowInfoButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowInfoButton", "showinfobutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfobutton")]
 		public bool ShowInfoButtonValue
		{
					get { return ShowInfoButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenDescription</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreendescription_b")]
		public virtual IBooleanFieldWrapper ShowInfoScreenDescription
		{
			get { return GetField<BooleanFieldWrapper>("ShowInfoScreenDescription", "showinfoscreendescription_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenDescription</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreendescription")]
 		public bool ShowInfoScreenDescriptionValue
		{
					get { return ShowInfoScreenDescription.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenHomepageLink</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreenhomepagelink_b")]
		public virtual IBooleanFieldWrapper ShowInfoScreenHomepageLink
		{
			get { return GetField<BooleanFieldWrapper>("ShowInfoScreenHomepageLink", "showinfoscreenhomepagelink_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenHomepageLink</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreenhomepagelink")]
 		public bool ShowInfoScreenHomepageLinkValue
		{
					get { return ShowInfoScreenHomepageLink.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenTitle</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreentitle_b")]
		public virtual IBooleanFieldWrapper ShowInfoScreenTitle
		{
			get { return GetField<BooleanFieldWrapper>("ShowInfoScreenTitle", "showinfoscreentitle_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowInfoScreenTitle</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinfoscreentitle")]
 		public bool ShowInfoScreenTitleValue
		{
					get { return ShowInfoScreenTitle.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowShareButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showsharebutton_b")]
		public virtual IBooleanFieldWrapper ShowShareButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowShareButton", "showsharebutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowShareButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showsharebutton")]
 		public bool ShowShareButtonValue
		{
					get { return ShowShareButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowVolumeButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showvolumebutton_b")]
		public virtual IBooleanFieldWrapper ShowVolumeButton
		{
			get { return GetField<BooleanFieldWrapper>("ShowVolumeButton", "showvolumebutton_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ShowVolumeButton</para><para>Data type: Checkbox</para></summary>
		[IndexField("showvolumebutton")]
 		public bool ShowVolumeButtonValue
		{
					get { return ShowVolumeButton.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: BufferOnPause</para><para>Data type: Checkbox</para></summary>
		[IndexField("bufferonpause_b")]
		public virtual IBooleanFieldWrapper BufferOnPause
		{
			get { return GetField<BooleanFieldWrapper>("BufferOnPause", "bufferonpause_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: BufferOnPause</para><para>Data type: Checkbox</para></summary>
		[IndexField("bufferonpause")]
 		public bool BufferOnPauseValue
		{
					get { return BufferOnPause.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: DefaultLanguage</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("defaultlanguage_t")]
		public virtual ITextFieldWrapper DefaultLanguage
		{
			get { return GetField<TextFieldWrapper>("DefaultLanguage", "defaultlanguage_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: DefaultLanguage</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("defaultlanguage")]
 		public string DefaultLanguageValue
		{
					get { return DefaultLanguage.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ID</para><para>Data type: ReadOnlyText</para></summary>
		public virtual ITextFieldWrapper ID
		{
			get { return GetField<TextFieldWrapper>("ID"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ID</para><para>Data type: ReadOnlyText</para></summary>
 		public string IDValue
		{
					get { return ID.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: IsDefault</para><para>Data type: ReadOnlyCheckBox</para></summary>
		public virtual ITextFieldWrapper IsDefault
		{
			get { return GetField<TextFieldWrapper>("isDefault"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: IsDefault</para><para>Data type: ReadOnlyCheckBox</para></summary>
 		public string IsDefaultValue
		{
					get { return IsDefault.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name_t")]
		public virtual ITextFieldWrapper Name
		{
			get { return GetField<TextFieldWrapper>("Name", "name_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Name</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("name")]
 		public string NameValue
		{
					get { return Name.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ProviderHomepageUrl</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("providerhomepageurl_t")]
		public virtual ITextFieldWrapper ProviderHomepageUrl
		{
			get { return GetField<TextFieldWrapper>("ProviderHomepageUrl", "providerhomepageurl_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ProviderHomepageUrl</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("providerhomepageurl")]
 		public string ProviderHomepageUrlValue
		{
					get { return ProviderHomepageUrl.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: AlwaysShow</para><para>Data type: Checkbox</para></summary>
		[IndexField("alwaysshow_b")]
		public virtual IBooleanFieldWrapper AlwaysShow
		{
			get { return GetField<BooleanFieldWrapper>("AlwaysShow", "alwaysshow_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: AlwaysShow</para><para>Data type: Checkbox</para></summary>
		[IndexField("alwaysshow")]
 		public bool AlwaysShowValue
		{
					get { return AlwaysShow.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ScrubberImageUrl</para><para>Data type: ImagePreview</para></summary>
		public virtual ITextFieldWrapper ScrubberImageUrl
		{
			get { return GetField<TextFieldWrapper>("ScrubberImageUrl"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ScrubberImageUrl</para><para>Data type: ImagePreview</para></summary>
 		public string ScrubberImageUrlValue
		{
					get { return ScrubberImageUrl.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: DiggSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("diggsharing_b")]
		public virtual IBooleanFieldWrapper DiggSharing
		{
			get { return GetField<BooleanFieldWrapper>("DiggSharing", "diggsharing_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: DiggSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("diggsharing")]
 		public bool DiggSharingValue
		{
					get { return DiggSharing.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: EmailSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("emailsharing_b")]
		public virtual IBooleanFieldWrapper EmailSharing
		{
			get { return GetField<BooleanFieldWrapper>("EmailSharing", "emailsharing_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: EmailSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("emailsharing")]
 		public bool EmailSharingValue
		{
					get { return EmailSharing.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: FacebookSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("facebooksharing_b")]
		public virtual IBooleanFieldWrapper FacebookSharing
		{
			get { return GetField<BooleanFieldWrapper>("FacebookSharing", "facebooksharing_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: FacebookSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("facebooksharing")]
 		public bool FacebookSharingValue
		{
					get { return FacebookSharing.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: TwitterSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("twittersharing_b")]
		public virtual IBooleanFieldWrapper TwitterSharing
		{
			get { return GetField<BooleanFieldWrapper>("TwitterSharing", "twittersharing_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: TwitterSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("twittersharing")]
 		public bool TwitterSharingValue
		{
					get { return TwitterSharing.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: UrlSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("urlsharing_b")]
		public virtual IBooleanFieldWrapper UrlSharing
		{
			get { return GetField<BooleanFieldWrapper>("UrlSharing", "urlsharing_b"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: UrlSharing</para><para>Data type: Checkbox</para></summary>
		[IndexField("urlsharing")]
 		public bool UrlSharingValue
		{
					get { return UrlSharing.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Alpha</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("alpha_t")]
		public virtual ITextFieldWrapper Alpha
		{
			get { return GetField<TextFieldWrapper>("Alpha", "alpha_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: Alpha</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("alpha")]
 		public string AlphaValue
		{
					get { return Alpha.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ClickUrl</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("clickurl_t")]
		public virtual ITextFieldWrapper ClickUrl
		{
			get { return GetField<TextFieldWrapper>("ClickUrl", "clickurl_t"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: ClickUrl</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("clickurl")]
 		public string ClickUrlValue
		{
					get { return ClickUrl.Value; }
				}
		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: WatermarkImageUrl</para><para>Data type: ImagePreview</para></summary>
		public virtual ITextFieldWrapper WatermarkImageUrl
		{
			get { return GetField<TextFieldWrapper>("WatermarkImageUrl"); }
		}

		/// <summary><para>Template: OoyalaVideoPlayer</para><para>Field: WatermarkImageUrl</para><para>Data type: ImagePreview</para></summary>
 		public string WatermarkImageUrlValue
		{
					get { return WatermarkImageUrl.Value; }
				}
	
	}
}
#endregion
#region Settings Folder (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Settings Folder</para>
	/// <para>ID: {FA1CB636-74B5-4105-9F7F-AA298B9ADD12}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Settings Folder</para>
	/// </summary>
	[TemplateMapping("{FA1CB636-74B5-4105-9F7F-AA298B9ADD12}", "InterfaceMap")]
	public partial interface ISettingsFolder : ICustomItemWrapper , LM.Model.Templates.Ignite.IIgniteFolder	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Sites/Settings/Settings Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FA1CB636-74B5-4105-9F7F-AA298B9ADD12}", typeof(Guid))]
	[TemplateMapping("{FA1CB636-74B5-4105-9F7F-AA298B9ADD12}", "")]
	public partial class SettingsFolder : CustomItemWrapper, ISettingsFolder
	{
		private Item _item = null;

		public SettingsFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SettingsFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SettingsFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SettingsFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Banner CTA (PokerCentral)
namespace LM.Model.Templates.PokerCentral
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Banner CTA</para>
	/// <para>ID: {FC95C32F-84E4-4A4D-A501-342D26B86B25}</para>
	/// <para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Banner CTA</para>
	/// </summary>
	[TemplateMapping("{FC95C32F-84E4-4A4D-A501-342D26B86B25}", "InterfaceMap")]
	public partial interface IBannerCTA : ICustomItemWrapper , LM.Model.Templates.PokerCentral.IBaseCTA	{		
    	/// <summary>
		/// <para>Template: Banner CTA</para><para>Field: CTABody</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("cta_body_t")]
		ITextFieldWrapper CTABody { get; }

    	/// <summary>
		/// <para>Template: Banner CTA</para><para>Field: CTABody</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("cta_body")]
 		string CTABodyValue { get; }
    	/// <summary>
		/// <para>Template: Banner CTA</para><para>Field: CTATitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_title_t")]
		ITextFieldWrapper CTATitle { get; }

    	/// <summary>
		/// <para>Template: Banner CTA</para><para>Field: CTATitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("cta_title")]
 		string CTATitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Poker Central/Marketing/CTAs/Banner CTA</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FC95C32F-84E4-4A4D-A501-342D26B86B25}", typeof(Guid))]
	[TemplateMapping("{FC95C32F-84E4-4A4D-A501-342D26B86B25}", "")]
	public partial class BannerCTA : CustomItemWrapper, IBannerCTA
	{
		private Item _item = null;

		public BannerCTA(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BannerCTA(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BannerCTA(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BannerCTA(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Banner CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link_t")]
		public virtual IGeneralLinkFieldWrapper CTALink
		{
			get { return GetField<GeneralLinkFieldWrapper>("CTA Link", "cta_link_t"); }
		}

		/// <summary><para>Template: Banner CTA</para><para>Field: CTALink</para><para>Data type: General Link</para></summary>
		[IndexField("cta_link")]
 		public string CTALinkValue
		{
					get { return CTALink.Value; }
				}
		/// <summary><para>Template: Banner CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text_t")]
		public virtual ITextFieldWrapper CTAText
		{
			get { return GetField<TextFieldWrapper>("CTA Text", "cta_text_t"); }
		}

		/// <summary><para>Template: Banner CTA</para><para>Field: CTAText</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_text")]
 		public string CTATextValue
		{
					get { return CTAText.Value; }
				}
		/// <summary><para>Template: Banner CTA</para><para>Field: CTABody</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("cta_body_t")]
		public virtual ITextFieldWrapper CTABody
		{
			get { return GetField<TextFieldWrapper>("CTA Body", "cta_body_t"); }
		}

		/// <summary><para>Template: Banner CTA</para><para>Field: CTABody</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("cta_body")]
 		public string CTABodyValue
		{
					get { return CTABody.Value; }
				}
		/// <summary><para>Template: Banner CTA</para><para>Field: CTATitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_title_t")]
		public virtual ITextFieldWrapper CTATitle
		{
			get { return GetField<TextFieldWrapper>("CTA Title", "cta_title_t"); }
		}

		/// <summary><para>Template: Banner CTA</para><para>Field: CTATitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("cta_title")]
 		public string CTATitleValue
		{
					get { return CTATitle.Value; }
				}
	
	}
}
#endregion
#region OoyalaAccountSettings (Ignite)
namespace LM.Model.Templates.Ignite
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: OoyalaAccountSettings</para>
	/// <para>ID: {FE1BA702-B3F4-4436-B9CF-4446642F5856}</para>
	/// <para>/sitecore/templates/MediaFramework/Ooyala/OoyalaAccountSettings</para>
	/// </summary>
	[TemplateMapping("{FE1BA702-B3F4-4436-B9CF-4446642F5856}", "InterfaceMap")]
	public partial interface IOoyalaAccountSettings : ICustomItemWrapper 	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/MediaFramework/Ooyala/OoyalaAccountSettings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FE1BA702-B3F4-4436-B9CF-4446642F5856}", typeof(Guid))]
	[TemplateMapping("{FE1BA702-B3F4-4436-B9CF-4446642F5856}", "")]
	public partial class OoyalaAccountSettings : CustomItemWrapper, IOoyalaAccountSettings
	{
		private Item _item = null;

		public OoyalaAccountSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public OoyalaAccountSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public OoyalaAccountSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public OoyalaAccountSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Media folder (ScSystem)
namespace LM.Model.Templates.ScSystem
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Media folder</para>
	/// <para>ID: {FE5DD826-48C6-436D-B87A-7C4210C7413B}</para>
	/// <para>/sitecore/templates/System/Media/Media folder</para>
	/// </summary>
	[TemplateMapping("{FE5DD826-48C6-436D-B87A-7C4210C7413B}", "InterfaceMap")]
	public partial interface IMediaFolder : ICustomItemWrapper 	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/System/Media/Media folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FE5DD826-48C6-436D-B87A-7C4210C7413B}", typeof(Guid))]
	[TemplateMapping("{FE5DD826-48C6-436D-B87A-7C4210C7413B}", "")]
	public partial class MediaFolder : CustomItemWrapper, IMediaFolder
	{
		private Item _item = null;

		public MediaFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public MediaFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public MediaFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public MediaFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
