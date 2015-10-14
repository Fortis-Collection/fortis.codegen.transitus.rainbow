/*
 * Fortis Template Models for Poker Central
 *
 * Generated at 10/14/2015 17:14:16
 */

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;

#region Assets (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Assets</para><para>ID: {1f443c63-bbc5-40f3-aee2-a7a70ea48f0d}</para><para>/sitecore/templates/Ignite/Assets</para></summary>
	[TemplateMapping("{1f443c63-bbc5-40f3-aee2-a7a70ea48f0d}", "InterfaceMap")]
	public partial interface IAssets :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{1f443c63-bbc5-40f3-aee2-a7a70ea48f0d}", typeof(Guid))]
	[TemplateMapping("{1f443c63-bbc5-40f3-aee2-a7a70ea48f0d}")]
	public partial class Assets : CustomItemWrapper, IAssets
	{
		public Assets(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Assets(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Ignite Bucket Template (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Ignite Bucket Template</para><para>ID: {88dd19f6-a03c-412c-ab52-5515342fc30d}</para><para>/sitecore/templates/Ignite/Ignite Bucket Template</para></summary>
	[TemplateMapping("{88dd19f6-a03c-412c-ab52-5515342fc30d}", "InterfaceMap")]
	public partial interface IIgniteBucketTemplate :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Ignite Bucket Template</para><para>Field: Item Buckets Wildcard Item</para><para>Data type: Treelist</para></summary>
		[IndexField("item_buckets_wildcard_item")]
		IListFieldWrapper ItemBucketsWildcardItem { get; }

    	/// <summary><para>Template: Ignite Bucket Template</para><para>Field: Item Buckets Wildcard Item</para><para>Data type: Treelist</para></summary>
		[IndexField("item_buckets_wildcard_item")]
		IEnumerable<Guid> ItemBucketsWildcardItemValue { get; }

    	/// <summary><para>Template: Ignite Bucket Template</para><para>Field: Item Buckets Wildcard Token</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		ILinkFieldWrapper ItemBucketsWildcardToken { get; }

    	/// <summary><para>Template: Ignite Bucket Template</para><para>Field: Item Buckets Wildcard Token</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		Guid ItemBucketsWildcardTokenValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{88dd19f6-a03c-412c-ab52-5515342fc30d}", typeof(Guid))]
	[TemplateMapping("{88dd19f6-a03c-412c-ab52-5515342fc30d}")]
	public partial class IgniteBucketTemplate : CustomItemWrapper, IIgniteBucketTemplate
	{
		public IgniteBucketTemplate(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public IgniteBucketTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: ItemBucketsWildcardItem</para><para>Data type: Treelist</para></summary>
		[IndexField("item_buckets_wildcard_item")]
		public virtual IListFieldWrapper ItemBucketsWildcardItem => this.GetField<ListFieldWrapper>("Item Buckets Wildcard Item");

		[IndexField("item_buckets_wildcard_item")]
 		public IEnumerable<Guid> ItemBucketsWildcardItemValue => this.ItemBucketsWildcardItem.Value;

		/// <summary><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		public virtual ILinkFieldWrapper ItemBucketsWildcardToken => this.GetField<LinkFieldWrapper>("Item Buckets Wildcard Token");

		[IndexField("item_buckets_wildcard_token")]
 		public Guid ItemBucketsWildcardTokenValue => this.ItemBucketsWildcardToken.Value;
	}
}
#endregion
#region Ignite Folder (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Ignite Folder</para><para>ID: {d9afffbe-d870-4278-b4fb-825d12201c4d}</para><para>/sitecore/templates/Ignite/Ignite Folder</para></summary>
	[TemplateMapping("{d9afffbe-d870-4278-b4fb-825d12201c4d}", "InterfaceMap")]
	public partial interface IIgniteFolder :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{d9afffbe-d870-4278-b4fb-825d12201c4d}", typeof(Guid))]
	[TemplateMapping("{d9afffbe-d870-4278-b4fb-825d12201c4d}")]
	public partial class IgniteFolder : CustomItemWrapper, IIgniteFolder
	{
		public IgniteFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public IgniteFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Ignite Rendering Parameters (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary>
	/// <para>Template: Ignite Rendering Parameters</para>
	/// <para>ID: {e13db450-f493-42d5-b1c1-536a57aed2a6}</para>
	/// <para>/sitecore/templates/Ignite/Ignite Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{e13db450-f493-42d5-b1c1-536a57aed2a6}", "InterfaceRenderingParameterMap")]
	public partial interface IIgniteRenderingParameters :
		IRenderingParameterWrapper	{
	}
	
	[TemplateMapping("{e13db450-f493-42d5-b1c1-536a57aed2a6}", "RenderingParameter")]
	public partial class IgniteRenderingParameters : RenderingParameterWrapper, IIgniteRenderingParameters
	{
		public IgniteRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider)
			: base(parameters, spawnProvider)
		{ }
	
	}
}
#endregion
#region Ignite Standard Template (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Ignite Standard Template</para><para>ID: {c99768fe-5ef4-4a9a-a06b-f6f926391940}</para><para>/sitecore/templates/Ignite/Ignite Standard Template</para></summary>
	[TemplateMapping("{c99768fe-5ef4-4a9a-a06b-f6f926391940}", "InterfaceMap")]
	public partial interface IIgniteStandardTemplate :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{c99768fe-5ef4-4a9a-a06b-f6f926391940}", typeof(Guid))]
	[TemplateMapping("{c99768fe-5ef4-4a9a-a06b-f6f926391940}")]
	public partial class IgniteStandardTemplate : CustomItemWrapper, IIgniteStandardTemplate
	{
		public IgniteStandardTemplate(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public IgniteStandardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Ignite Wildcard Template (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Ignite Wildcard Template</para><para>ID: {84a7c848-246d-4e21-9164-5b0efa1aac9d}</para><para>/sitecore/templates/Ignite/Ignite Wildcard Template</para></summary>
	[TemplateMapping("{84a7c848-246d-4e21-9164-5b0efa1aac9d}", "InterfaceMap")]
	public partial interface IIgniteWildcardTemplate :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: __WildcardItemBucket</para><para>Data type: Droptree</para></summary>
		[IndexField("__wildcarditembucket")]
		ILinkFieldWrapper WildcardItemBucket { get; }

    	/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: __WildcardItemBucket</para><para>Data type: Droptree</para></summary>
		[IndexField("__wildcarditembucket")]
		Guid WildcardItemBucketValue { get; }

    	/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: Item Buckets Wildcard Token</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		ILinkFieldWrapper ItemBucketsWildcardToken { get; }

    	/// <summary><para>Template: Ignite Wildcard Template</para><para>Field: Item Buckets Wildcard Token</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		Guid ItemBucketsWildcardTokenValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{84a7c848-246d-4e21-9164-5b0efa1aac9d}", typeof(Guid))]
	[TemplateMapping("{84a7c848-246d-4e21-9164-5b0efa1aac9d}")]
	public partial class IgniteWildcardTemplate : CustomItemWrapper, IIgniteWildcardTemplate
	{
		public IgniteWildcardTemplate(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public IgniteWildcardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: WildcardItemBucket</para><para>Data type: Droptree</para></summary>
		[IndexField("__wildcarditembucket")]
		public virtual ILinkFieldWrapper WildcardItemBucket => this.GetField<LinkFieldWrapper>("__WildcardItemBucket");

		[IndexField("__wildcarditembucket")]
 		public Guid WildcardItemBucketValue => this.WildcardItemBucket.Value;

		/// <summary><para>Field: ItemBucketsWildcardToken</para><para>Data type: Droplink</para></summary>
		[IndexField("item_buckets_wildcard_token")]
		public virtual ILinkFieldWrapper ItemBucketsWildcardToken => this.GetField<LinkFieldWrapper>("Item Buckets Wildcard Token");

		[IndexField("item_buckets_wildcard_token")]
 		public Guid ItemBucketsWildcardTokenValue => this.ItemBucketsWildcardToken.Value;
	}
}
#endregion
#region Local Content Folder (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Local Content Folder</para><para>ID: {cad3fc26-1b71-4fee-809b-acc0f05f6e6c}</para><para>/sitecore/templates/Ignite/Local Content Folder</para></summary>
	[TemplateMapping("{cad3fc26-1b71-4fee-809b-acc0f05f6e6c}", "InterfaceMap")]
	public partial interface ILocalContentFolder :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{cad3fc26-1b71-4fee-809b-acc0f05f6e6c}", typeof(Guid))]
	[TemplateMapping("{cad3fc26-1b71-4fee-809b-acc0f05f6e6c}")]
	public partial class LocalContentFolder : CustomItemWrapper, ILocalContentFolder
	{
		public LocalContentFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public LocalContentFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region HtmlPhrase (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: HtmlPhrase</para><para>ID: {4ad20f42-1a7d-4973-96f9-dc37152d07da}</para><para>/sitecore/templates/Ignite/Phrases/HtmlPhrase</para></summary>
	[TemplateMapping("{4ad20f42-1a7d-4973-96f9-dc37152d07da}", "InterfaceMap")]
	public partial interface IHtmlPhrase :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase")]
		IRichTextFieldWrapper Phrase { get; }

    	/// <summary><para>Template: HtmlPhrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase")]
		string PhraseValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4ad20f42-1a7d-4973-96f9-dc37152d07da}", typeof(Guid))]
	[TemplateMapping("{4ad20f42-1a7d-4973-96f9-dc37152d07da}")]
	public partial class HtmlPhrase : CustomItemWrapper, IHtmlPhrase
	{
		public HtmlPhrase(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public HtmlPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase")]
		public virtual IRichTextFieldWrapper Phrase => this.GetField<RichTextFieldWrapper>("Phrase");

		[IndexField("phrase")]
 		public string PhraseValue => this.Phrase.Value;
	}
}
#endregion
#region Image Phrase (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Image Phrase</para><para>ID: {813a77f9-58c3-4941-bd97-5bfce4727f4a}</para><para>/sitecore/templates/Ignite/Phrases/Image Phrase</para></summary>
	[TemplateMapping("{813a77f9-58c3-4941-bd97-5bfce4727f4a}", "InterfaceMap")]
	public partial interface IImagePhrase :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Image Phrase</para><para>Field: Phrase</para><para>Data type: Image</para></summary>
		IImageFieldWrapper Phrase { get; }

    	/// <summary><para>Template: Image Phrase</para><para>Field: Phrase</para><para>Data type: Image</para></summary>
		string PhraseValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{813a77f9-58c3-4941-bd97-5bfce4727f4a}", typeof(Guid))]
	[TemplateMapping("{813a77f9-58c3-4941-bd97-5bfce4727f4a}")]
	public partial class ImagePhrase : CustomItemWrapper, IImagePhrase
	{
		public ImagePhrase(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public ImagePhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Phrase</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Phrase => this.GetField<ImageFieldWrapper>("Phrase");

 		public string PhraseValue => this.Phrase.Value;
	}
}
#endregion
#region Phrase Dictionary (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Phrase Dictionary</para><para>ID: {59a892a5-11fa-4f2a-9e84-99b56da2d294}</para><para>/sitecore/templates/Ignite/Phrases/Phrase Dictionary</para></summary>
	[TemplateMapping("{59a892a5-11fa-4f2a-9e84-99b56da2d294}", "InterfaceMap")]
	public partial interface IPhraseDictionary :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{59a892a5-11fa-4f2a-9e84-99b56da2d294}", typeof(Guid))]
	[TemplateMapping("{59a892a5-11fa-4f2a-9e84-99b56da2d294}")]
	public partial class PhraseDictionary : CustomItemWrapper, IPhraseDictionary
	{
		public PhraseDictionary(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public PhraseDictionary(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Phrase (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Phrase</para><para>ID: {dc9fa523-7f26-44f7-96a5-e4ff9b64658a}</para><para>/sitecore/templates/Ignite/Phrases/Phrase</para></summary>
	[TemplateMapping("{dc9fa523-7f26-44f7-96a5-e4ff9b64658a}", "InterfaceMap")]
	public partial interface IPhrase :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{dc9fa523-7f26-44f7-96a5-e4ff9b64658a}", typeof(Guid))]
	[TemplateMapping("{dc9fa523-7f26-44f7-96a5-e4ff9b64658a}")]
	public partial class Phrase : CustomItemWrapper, IPhrase
	{
		public Phrase(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Phrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Phrases Folder (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: Phrases Folder</para><para>ID: {b5f5e686-fa8e-4b89-b9d9-50bc53168c1a}</para><para>/sitecore/templates/Ignite/Phrases/Phrases Folder</para></summary>
	[TemplateMapping("{b5f5e686-fa8e-4b89-b9d9-50bc53168c1a}", "InterfaceMap")]
	public partial interface IPhrasesFolder :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{b5f5e686-fa8e-4b89-b9d9-50bc53168c1a}", typeof(Guid))]
	[TemplateMapping("{b5f5e686-fa8e-4b89-b9d9-50bc53168c1a}")]
	public partial class PhrasesFolder : CustomItemWrapper, IPhrasesFolder
	{
		public PhrasesFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public PhrasesFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region TextPhrase (Ignite)
namespace Fortis.Model.Templates.Ignite
{
	/// <summary><para>Template: TextPhrase</para><para>ID: {a24644f1-7060-46c4-9acd-b181acb653f7}</para><para>/sitecore/templates/Ignite/Phrases/TextPhrase</para></summary>
	[TemplateMapping("{a24644f1-7060-46c4-9acd-b181acb653f7}", "InterfaceMap")]
	public partial interface ITextPhrase :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase")]
		ITextFieldWrapper Phrase { get; }

    	/// <summary><para>Template: TextPhrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase")]
		string PhraseValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a24644f1-7060-46c4-9acd-b181acb653f7}", typeof(Guid))]
	[TemplateMapping("{a24644f1-7060-46c4-9acd-b181acb653f7}")]
	public partial class TextPhrase : CustomItemWrapper, ITextPhrase
	{
		public TextPhrase(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public TextPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase")]
		public virtual ITextFieldWrapper Phrase => this.GetField<TextFieldWrapper>("Phrase");

		[IndexField("phrase")]
 		public string PhraseValue => this.Phrase.Value;
	}
}
#endregion
#region Content (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Content</para><para>ID: {e9828587-24e6-478b-8778-c36fcc93c062}</para><para>/sitecore/templates/User Defined/Shared/Content/Content</para></summary>
	[TemplateMapping("{e9828587-24e6-478b-8778-c36fcc93c062}", "InterfaceMap")]
	public partial interface IContent :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Content</para><para>Field: Content Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		IRichTextFieldWrapper ContentBody { get; }

    	/// <summary><para>Template: Content</para><para>Field: Content Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		string ContentBodyValue { get; }

    	/// <summary><para>Template: Content</para><para>Field: Page Summary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
		ITextFieldWrapper PageSummary { get; }

    	/// <summary><para>Template: Content</para><para>Field: Page Summary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
		string PageSummaryValue { get; }

    	/// <summary><para>Template: Content</para><para>Field: Page Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
		ITextFieldWrapper PageTitle { get; }

    	/// <summary><para>Template: Content</para><para>Field: Page Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
		string PageTitleValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{e9828587-24e6-478b-8778-c36fcc93c062}", typeof(Guid))]
	[TemplateMapping("{e9828587-24e6-478b-8778-c36fcc93c062}")]
	public partial class Content : CustomItemWrapper, IContent
	{
		public Content(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Content(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		public virtual IRichTextFieldWrapper ContentBody => this.GetField<RichTextFieldWrapper>("Content Body");

		[IndexField("content_body")]
 		public string ContentBodyValue => this.ContentBody.Value;

		/// <summary><para>Field: PageSummary</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("page_summary")]
		public virtual ITextFieldWrapper PageSummary => this.GetField<TextFieldWrapper>("Page Summary");

		[IndexField("page_summary")]
 		public string PageSummaryValue => this.PageSummary.Value;

		/// <summary><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
		public virtual ITextFieldWrapper PageTitle => this.GetField<TextFieldWrapper>("Page Title");

		[IndexField("page_title")]
 		public string PageTitleValue => this.PageTitle.Value;
	}
}
#endregion
#region Hero (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Hero</para><para>ID: {b19b286c-16ce-4a39-84de-d77ea0441b4f}</para><para>/sitecore/templates/User Defined/Shared/Content/Hero</para></summary>
	[TemplateMapping("{b19b286c-16ce-4a39-84de-d77ea0441b4f}", "InterfaceMap")]
	public partial interface IHero :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Hero</para><para>Field: Hero Image</para><para>Data type: Image</para></summary>
		IImageFieldWrapper HeroImage { get; }

    	/// <summary><para>Template: Hero</para><para>Field: Hero Image</para><para>Data type: Image</para></summary>
		string HeroImageValue { get; }

    	/// <summary><para>Template: Hero</para><para>Field: Hero Image Mobile</para><para>Data type: Image</para></summary>
		IImageFieldWrapper HeroImageMobile { get; }

    	/// <summary><para>Template: Hero</para><para>Field: Hero Image Mobile</para><para>Data type: Image</para></summary>
		string HeroImageMobileValue { get; }

    	/// <summary><para>Template: Hero</para><para>Field: Hero Video</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("hero_video")]
		IListFieldWrapper HeroVideo { get; }

    	/// <summary><para>Template: Hero</para><para>Field: Hero Video</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("hero_video")]
		IEnumerable<Guid> HeroVideoValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{b19b286c-16ce-4a39-84de-d77ea0441b4f}", typeof(Guid))]
	[TemplateMapping("{b19b286c-16ce-4a39-84de-d77ea0441b4f}")]
	public partial class Hero : CustomItemWrapper, IHero
	{
		public Hero(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Hero(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: HeroImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper HeroImage => this.GetField<ImageFieldWrapper>("Hero Image");

 		public string HeroImageValue => this.HeroImage.Value;

		/// <summary><para>Field: HeroImageMobile</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper HeroImageMobile => this.GetField<ImageFieldWrapper>("Hero Image Mobile");

 		public string HeroImageMobileValue => this.HeroImageMobile.Value;

		/// <summary><para>Field: HeroVideo</para><para>Data type: Multilist with Search</para></summary>
		[IndexField("hero_video")]
		public virtual IListFieldWrapper HeroVideo => this.GetField<ListFieldWrapper>("Hero Video");

		[IndexField("hero_video")]
 		public IEnumerable<Guid> HeroVideoValue => this.HeroVideo.Value;
	}
}
#endregion
#region Lookup Folder (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Lookup Folder</para><para>ID: {2a757a67-4f93-4d03-8c63-18eb2e9c194a}</para><para>/sitecore/templates/User Defined/Shared/Content/Lookup Folder</para></summary>
	[TemplateMapping("{2a757a67-4f93-4d03-8c63-18eb2e9c194a}", "InterfaceMap")]
	public partial interface ILookupFolder :
		ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2a757a67-4f93-4d03-8c63-18eb2e9c194a}", typeof(Guid))]
	[TemplateMapping("{2a757a67-4f93-4d03-8c63-18eb2e9c194a}")]
	public partial class LookupFolder : CustomItemWrapper, ILookupFolder
	{
		public LookupFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public LookupFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Lookup Item (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Lookup Item</para><para>ID: {e81f2fc8-28be-4d75-b6b5-194807d3da00}</para><para>/sitecore/templates/User Defined/Shared/Content/Lookup Item</para></summary>
	[TemplateMapping("{e81f2fc8-28be-4d75-b6b5-194807d3da00}", "InterfaceMap")]
	public partial interface ILookupItem :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Lookup Item</para><para>Field: Text Value</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("text_value")]
		ITextFieldWrapper TextValue { get; }

    	/// <summary><para>Template: Lookup Item</para><para>Field: Text Value</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("text_value")]
		string TextValueValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{e81f2fc8-28be-4d75-b6b5-194807d3da00}", typeof(Guid))]
	[TemplateMapping("{e81f2fc8-28be-4d75-b6b5-194807d3da00}")]
	public partial class LookupItem : CustomItemWrapper, ILookupItem
	{
		public LookupItem(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public LookupItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: TextValue</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("text_value")]
		public virtual ITextFieldWrapper TextValue => this.GetField<TextFieldWrapper>("Text Value");

		[IndexField("text_value")]
 		public string TextValueValue => this.TextValue.Value;
	}
}
#endregion
#region Custom Tag Rendering Parameters (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Custom Tag Rendering Parameters</para><para>ID: {b5e251b7-c892-4e0f-b20c-01b196ac4135}</para><para>/sitecore/templates/User Defined/Shared/Content/Rendering Parameters/Custom Tag Rendering Parameters</para></summary>
	[TemplateMapping("{b5e251b7-c892-4e0f-b20c-01b196ac4135}", "InterfaceMap")]
	public partial interface ICustomTagRenderingParameters :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Custom Tag Rendering Parameters</para><para>Field: Html Tag</para><para>Data type: Droptree</para></summary>
		[IndexField("html_tag")]
		ILinkFieldWrapper HtmlTag { get; }

    	/// <summary><para>Template: Custom Tag Rendering Parameters</para><para>Field: Html Tag</para><para>Data type: Droptree</para></summary>
		[IndexField("html_tag")]
		Guid HtmlTagValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{b5e251b7-c892-4e0f-b20c-01b196ac4135}", typeof(Guid))]
	[TemplateMapping("{b5e251b7-c892-4e0f-b20c-01b196ac4135}")]
	public partial class CustomTagRenderingParameters : CustomItemWrapper, ICustomTagRenderingParameters
	{
		public CustomTagRenderingParameters(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public CustomTagRenderingParameters(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: HtmlTag</para><para>Data type: Droptree</para></summary>
		[IndexField("html_tag")]
		public virtual ILinkFieldWrapper HtmlTag => this.GetField<LinkFieldWrapper>("Html Tag");

		[IndexField("html_tag")]
 		public Guid HtmlTagValue => this.HtmlTag.Value;
	}
}
#endregion
#region Module Title Rendering Parameters (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Module Title Rendering Parameters</para><para>ID: {2e5de23f-50c0-4a4d-8651-410921da5606}</para><para>/sitecore/templates/User Defined/Shared/Content/Rendering Parameters/Module Title Rendering Parameters</para></summary>
	[TemplateMapping("{2e5de23f-50c0-4a4d-8651-410921da5606}", "InterfaceMap")]
	public partial interface IModuleTitleRenderingParameters :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Module Title Rendering Parameters</para><para>Field: Css Class</para><para>Data type: Droptree</para></summary>
		[IndexField("css_class")]
		ILinkFieldWrapper CssClass { get; }

    	/// <summary><para>Template: Module Title Rendering Parameters</para><para>Field: Css Class</para><para>Data type: Droptree</para></summary>
		[IndexField("css_class")]
		Guid CssClassValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2e5de23f-50c0-4a4d-8651-410921da5606}", typeof(Guid))]
	[TemplateMapping("{2e5de23f-50c0-4a4d-8651-410921da5606}")]
	public partial class ModuleTitleRenderingParameters : CustomItemWrapper, IModuleTitleRenderingParameters
	{
		public ModuleTitleRenderingParameters(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public ModuleTitleRenderingParameters(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: CssClass</para><para>Data type: Droptree</para></summary>
		[IndexField("css_class")]
		public virtual ILinkFieldWrapper CssClass => this.GetField<LinkFieldWrapper>("Css Class");

		[IndexField("css_class")]
 		public Guid CssClassValue => this.CssClass.Value;
	}
}
#endregion
#region Trending (PokerCentral)
namespace Fortis.Model.Templates.PokerCentral
{
	/// <summary><para>Template: Trending</para><para>ID: {a53e5bcd-d614-465a-9aee-d0cefc432348}</para><para>/sitecore/templates/User Defined/Shared/Content/Trending</para></summary>
	[TemplateMapping("{a53e5bcd-d614-465a-9aee-d0cefc432348}", "InterfaceMap")]
	public partial interface ITrending :
		ICustomItemWrapper
	{

    	/// <summary><para>Template: Trending</para><para>Field: Is Trending</para><para>Data type: Checkbox</para></summary>
		[IndexField("is_trending")]
		IBooleanFieldWrapper IsTrending { get; }

    	/// <summary><para>Template: Trending</para><para>Field: Is Trending</para><para>Data type: Checkbox</para></summary>
		[IndexField("is_trending")]
		bool IsTrendingValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a53e5bcd-d614-465a-9aee-d0cefc432348}", typeof(Guid))]
	[TemplateMapping("{a53e5bcd-d614-465a-9aee-d0cefc432348}")]
	public partial class Trending : CustomItemWrapper, ITrending
	{
		public Trending(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Trending(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: IsTrending</para><para>Data type: Checkbox</para></summary>
		[IndexField("is_trending")]
		public virtual IBooleanFieldWrapper IsTrending => this.GetField<BooleanFieldWrapper>("Is Trending");

		[IndexField("is_trending")]
 		public bool IsTrendingValue => this.IsTrending.Value;
	}
}
#endregion


// Generated in 243ms
// Found 20 templates in 2 folders [C:\Projects\fortis.codegen.transitus.rainbow\Source\..\Unicorn\Default Configuration]
