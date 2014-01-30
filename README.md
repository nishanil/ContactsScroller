ContactsScroller
================

Ported to Xamarin.iOS (using bindings) from here : [Scroller](https://github.com/raweng/Scroller)

See the output here: [Video](http://www.screencast.com/t/UDK6OVzhoxm)

It has 2 Projects: 
	
	1. ScrollerStatic - Static Library 
	2. ScrollerBinding - Binding Project and the iOS app
	
Steps followed here are inspired by the Xamarin Docs on [iOS Binding Walkthrough](http://docs.xamarin.com/guides/ios/advanced_topics/binding_objective-c/binding_walkthrough/). 

Please note: Objective Sharpie was not used here. It was simple enough that I just needed one class ScrollViewController which I hand coded.

##Compiling

If you have issues with compiling - add this to your Compiler Arguments under "iOS Build" of project options (Scroller.iOS project)
	
		 -gcc_flags "-dead_strip" -dlsym:true

Have a question? [@nishanil](http://nishanil) on twitter!
