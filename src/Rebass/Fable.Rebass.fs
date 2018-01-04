module Fable.Rebass

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop

module Props =
  [<Erase>]
  type ResponsiveSpacingValue = 
    | Scale of int
    | Px of float
    | Custom of string
    | Responsive of ResponsiveSpacingValue list

  [<Erase>]
  type ResponsiveWidthValue = 
    | Percent of float
    | Px of float
    | Custom of string
    | Responsive of ResponsiveWidthValue list

  type [<RequireQualifiedAccess>] BoxProp =
    | [<CompiledName("m")>] Margin of ResponsiveSpacingValue
    | [<CompiledName("mt")>] MarginTop of ResponsiveSpacingValue
    | [<CompiledName("mr")>] MarginRight of ResponsiveSpacingValue
    | [<CompiledName("mb")>] MarginBottom of ResponsiveSpacingValue
    | [<CompiledName("ml")>] MarginLeft of ResponsiveSpacingValue
    | [<CompiledName("mx")>] MarginX of ResponsiveSpacingValue
    | [<CompiledName("my")>] MarginY of ResponsiveSpacingValue
    | [<CompiledName("p")>] Padding of ResponsiveSpacingValue
    | [<CompiledName("pt")>] PaddingTop of ResponsiveSpacingValue
    | [<CompiledName("pr")>] PaddingRight of ResponsiveSpacingValue
    | [<CompiledName("pb")>] PaddingBottom of ResponsiveSpacingValue
    | [<CompiledName("pl")>] PaddingLeft of ResponsiveSpacingValue
    | [<CompiledName("px")>] PaddingX of ResponsiveSpacingValue
    | [<CompiledName("py")>] PaddingY of ResponsiveSpacingValue
    | Color of string
    | Bg of string
    | Width of ResponsiveWidthValue

    interface Fable.Helpers.React.Props.IProp

  type [<RequireQualifiedAccess>] CardProp =
    | [<CompiledName("m")>] Margin of ResponsiveSpacingValue
    | [<CompiledName("mt")>] MarginTop of ResponsiveSpacingValue
    | [<CompiledName("mr")>] MarginRight of ResponsiveSpacingValue
    | [<CompiledName("mb")>] MarginBottom of ResponsiveSpacingValue
    | [<CompiledName("ml")>] MarginLeft of ResponsiveSpacingValue
    | [<CompiledName("mx")>] MarginX of ResponsiveSpacingValue
    | [<CompiledName("my")>] MarginY of ResponsiveSpacingValue
    | [<CompiledName("p")>] Padding of ResponsiveSpacingValue
    | [<CompiledName("pt")>] PaddingTop of ResponsiveSpacingValue
    | [<CompiledName("pr")>] PaddingRight of ResponsiveSpacingValue
    | [<CompiledName("pb")>] PaddingBottom of ResponsiveSpacingValue
    | [<CompiledName("pl")>] PaddingLeft of ResponsiveSpacingValue
    | [<CompiledName("px")>] PaddingX of ResponsiveSpacingValue
    | [<CompiledName("py")>] PaddingY of ResponsiveSpacingValue
    | Color of string
    | Bg of string
    | Width of ResponsiveWidthValue

    interface Fable.Helpers.React.Props.IProp

module Imports =
  let providerEl: obj = import "Provider" "rebass"

  // Grid Styled
  let boxEl: obj = import "Box" "rebass"
  let flexEl: obj = import "Flex" "rebass"

  // Components
  let absoluteEl: obj = import "Absolute" "rebass"
  let arrowEl: obj = import "Arrow" "rebass"
  let avatarEl: obj = import "Avatar" "rebass"
  let backgroundImageEl: obj = import "BackgroundImage" "rebass"
  let badgeEl: obj = import "Badge" "rebass"
  let bannerEl: obj = import "Banner" "rebass"
  let blockLinkEl: obj = import "BlockLink" "rebass"
  let blockquoteEl: obj = import "Blockquote" "rebass"
  let borderEl: obj = import "Border" "rebass"
  let buttonEl: obj = import "Button" "rebass"
  let buttonCircleEl: obj = import "ButtonCircle" "rebass"
  let buttonOutlineEl: obj = import "ButtonOutline" "rebass"
  let buttonTransparentEl: obj = import "ButtonTransparent" "rebass"
  let cardEl: obj = import "Card" "rebass"
  let carouselEl: obj = import "Carousel" "rebass"
  let carouselSlideEl: obj = import "CarouselSlide" "rebass"
  let checkboxEl: obj = import "Checkbox" "rebass"
  let circleEl: obj = import "Circle" "rebass"
  let closeEl: obj = import "Close" "rebass"
  let codeEl: obj = import "Code" "rebass"
  let columnEl: obj = import "Column" "rebass"
  let containerEl: obj = import "Container" "rebass"
  let dividerEl: obj = import "Divider" "rebass"
  let donutEl: obj = import "Donut" "rebass"
  let dotButtonEl: obj = import "DotButton" "rebass"
  let drawerEl: obj = import "Drawer" "rebass"
  let embedEl: obj = import "Embed" "rebass"
  let fixedEl: obj = import "Fixed" "rebass"
  let groupEl: obj = import "Group" "rebass"
  let headingEl: obj = import "Heading" "rebass"
  let imageEl: obj = import "Image" "rebass"
  let inputEl: obj = import "Input" "rebass"
  let labelEl: obj = import "Label" "rebass"
  let leadEl: obj = import "Lead" "rebass"
  let linkEl: obj = import "Link" "rebass"
  let measureEl: obj = import "Measure" "rebass"
  let mediaEl: obj = import "Media" "rebass"
  let messageEl: obj = import "Message" "rebass"
  let navLinkEl: obj = import "NavLink" "rebass"
  let overlayEl: obj = import "Overlay" "rebass"
  let panelEl: obj = import "Panel" "rebass"
  let panelFooterEl: obj = import "PanelFooter" "rebass"
  let panelHeaderEl: obj = import "PanelHeader" "rebass"
  let preEl: obj = import "Pre" "rebass"
  let progressEl: obj = import "Progress" "rebass"
  let radioEl: obj = import "Radio" "rebass"
  let relativeEl: obj = import "Relative" "rebass"
  let rowEl: obj = import "Row" "rebass"
  let sampEl: obj = import "Samp" "rebass"
  let scrollCarouselEl: obj = import "ScrollCarousel" "rebass"
  let selectEl: obj = import "Select" "rebass"
  let sliderEl: obj = import "Slider" "rebass"
  let smallEl: obj = import "Small" "rebass"
  let starEl: obj = import "Star" "rebass"
  let stickyEl: obj = import "Sticky" "rebass"
  let subheadEl: obj = import "Subhead" "rebass"
  let switchEl: obj = import "Switch" "rebass"
  let tabItemEl: obj = import "TabItem" "rebass"
  let tabsEl: obj = import "Tabs" "rebass"
  let textEl: obj = import "Text" "rebass"
  let textareaEl: obj = import "Textarea" "rebass"
  let toolbarEl: obj = import "Toolbar" "rebass"
  let tooltipEl: obj = import "Tooltip" "rebass"
  let truncateEl: obj = import "Truncate" "rebass"

open Fable.Helpers.React
open Imports
open Props

let inline Provider (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (providerEl, keyValueList CaseRules.LowerFirst props, children)

let inline Box (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (boxEl, keyValueList CaseRules.LowerFirst props, children)

let inline Absolute (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (absoluteEl, keyValueList CaseRules.LowerFirst props, children)

let inline Arrow (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (arrowEl, keyValueList CaseRules.LowerFirst props, children)

let inline Avatar (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (avatarEl, keyValueList CaseRules.LowerFirst props, children)

let inline BackgroundImage (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (backgroundImageEl, keyValueList CaseRules.LowerFirst props, children)

let inline Badge (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (badgeEl, keyValueList CaseRules.LowerFirst props, children)

let inline Banner (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (bannerEl, keyValueList CaseRules.LowerFirst props, children)

let inline BlockLink (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (blockLinkEl, keyValueList CaseRules.LowerFirst props, children)

let inline Blockquote (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (blockquoteEl, keyValueList CaseRules.LowerFirst props, children)

let inline Border (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (borderEl, keyValueList CaseRules.LowerFirst props, children)

let inline Button (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (buttonEl, keyValueList CaseRules.LowerFirst props, children)

let inline ButtonCircle (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (buttonCircleEl, keyValueList CaseRules.LowerFirst props, children)

let inline ButtonOutline (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (buttonOutlineEl, keyValueList CaseRules.LowerFirst props, children)

let inline ButtonTransparent (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (buttonTransparentEl, keyValueList CaseRules.LowerFirst props, children)

let inline Card (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (cardEl, keyValueList CaseRules.LowerFirst props, children)

let inline Carousel (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (carouselEl, keyValueList CaseRules.LowerFirst props, children)

let inline CarouselSlide (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (carouselSlideEl, keyValueList CaseRules.LowerFirst props, children)

let inline Checkbox (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (checkboxEl, keyValueList CaseRules.LowerFirst props, children)

let inline Circle (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (circleEl, keyValueList CaseRules.LowerFirst props, children)

let inline Close (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (closeEl, keyValueList CaseRules.LowerFirst props, children)

let inline Code (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (codeEl, keyValueList CaseRules.LowerFirst props, children)

let inline Column (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (columnEl, keyValueList CaseRules.LowerFirst props, children)

let inline Container (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (containerEl, keyValueList CaseRules.LowerFirst props, children)

let inline Divider (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (dividerEl, keyValueList CaseRules.LowerFirst props, children)

let inline Donut (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (donutEl, keyValueList CaseRules.LowerFirst props, children)

let inline DotButton (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (dotButtonEl, keyValueList CaseRules.LowerFirst props, children)

let inline Drawer (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (drawerEl, keyValueList CaseRules.LowerFirst props, children)

let inline Embed (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (embedEl, keyValueList CaseRules.LowerFirst props, children)

let inline Fixed (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (fixedEl, keyValueList CaseRules.LowerFirst props, children)

let inline Group (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (groupEl, keyValueList CaseRules.LowerFirst props, children)

let inline Heading (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (headingEl, keyValueList CaseRules.LowerFirst props, children)

let inline Image (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (imageEl, keyValueList CaseRules.LowerFirst props, children)

let inline Input (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (inputEl, keyValueList CaseRules.LowerFirst props, children)

let inline Label (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (labelEl, keyValueList CaseRules.LowerFirst props, children)

let inline Lead (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (leadEl, keyValueList CaseRules.LowerFirst props, children)

let inline Link (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (linkEl, keyValueList CaseRules.LowerFirst props, children)

let inline Measure (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (measureEl, keyValueList CaseRules.LowerFirst props, children)

let inline Media (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (mediaEl, keyValueList CaseRules.LowerFirst props, children)

let inline Message (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (messageEl, keyValueList CaseRules.LowerFirst props, children)

let inline NavLink (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (navLinkEl, keyValueList CaseRules.LowerFirst props, children)

let inline Overlay (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (overlayEl, keyValueList CaseRules.LowerFirst props, children)

let inline Panel (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (panelEl, keyValueList CaseRules.LowerFirst props, children)

let inline PanelFooter (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (panelFooterEl, keyValueList CaseRules.LowerFirst props, children)

let inline PanelHeader (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (panelHeaderEl, keyValueList CaseRules.LowerFirst props, children)

let inline Pre (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (preEl, keyValueList CaseRules.LowerFirst props, children)

let inline Progress (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (progressEl, keyValueList CaseRules.LowerFirst props, children)

let inline Radio (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (radioEl, keyValueList CaseRules.LowerFirst props, children)

let inline Relative (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (relativeEl, keyValueList CaseRules.LowerFirst props, children)

let inline Row (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (rowEl, keyValueList CaseRules.LowerFirst props, children)

let inline Samp (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (sampEl, keyValueList CaseRules.LowerFirst props, children)

let inline ScrollCarousel (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (scrollCarouselEl, keyValueList CaseRules.LowerFirst props, children)

let inline Select (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (selectEl, keyValueList CaseRules.LowerFirst props, children)

let inline Slider (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (sliderEl, keyValueList CaseRules.LowerFirst props, children)

let inline Small (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (smallEl, keyValueList CaseRules.LowerFirst props, children)

let inline Star (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (starEl, keyValueList CaseRules.LowerFirst props, children)

let inline Sticky (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (stickyEl, keyValueList CaseRules.LowerFirst props, children)

let inline Subhead (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (subheadEl, keyValueList CaseRules.LowerFirst props, children)

let inline Switch (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (switchEl, keyValueList CaseRules.LowerFirst props, children)

let inline TabItem (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (tabItemEl, keyValueList CaseRules.LowerFirst props, children)

let inline Tabs (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (tabsEl, keyValueList CaseRules.LowerFirst props, children)

let inline Text (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (textEl, keyValueList CaseRules.LowerFirst props, children)

let inline Textarea (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (textareaEl, keyValueList CaseRules.LowerFirst props, children)

let inline Toolbar (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (toolbarEl, keyValueList CaseRules.LowerFirst props, children)

let inline Tooltip (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (tooltipEl, keyValueList CaseRules.LowerFirst props, children)

let inline Truncate (props: IProp list) (children: React.ReactElement list): React.ReactElement =
  createElement (truncateEl, keyValueList CaseRules.LowerFirst props, children)
