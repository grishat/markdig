﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using System;
using NUnit.Framework;

namespace Textamina.Markdig.Tests
{
    [TestFixture]
    public class TestPlayParser
    {
        [Test]
        public void TestSimple()
        {
            var text = @"
Term 1
:   This is a definition item
    With a paragraph
    > This is a block quote

    - This is a list
    - item2

    ```java
    Test


    ```

    And a lazy line
:   This ia another definition item

Term2
Term3 *with some inline*
:   This is another definition for term2
";

            //            var reader = new StringReader(@"> > toto tata
            //> titi toto
            //");

            //var result = Markdown.ToHtml(text, new MarkdownPipeline().UseFootnotes().UseStrikethroughSuperAndSubScript());
            var result = Markdown.ToHtml(text, new MarkdownPipeline().UseDefinitionList());
            //File.WriteAllText("test.html", result, Encoding.UTF8);
            Console.WriteLine(result);
        }


//        var text = @"
//+-----------------------------------+--------------------------------------+
//| - this is a list                  | > We have a blockquote
//| - this is a second item           |
//|                                   |
//| ```                               |
//| Yes                               |
//| ```                               |
//+===================================+======================================+
//| This is a second line             | 
//+-----------------------------------+--------------------------------------+

//:::spoiler  {#yessss}
//This is a spoiler
//:::

///| we have mult | paragraph    |
///| we have a new colspan with a long line
///| and lots of text
//";


    }
}