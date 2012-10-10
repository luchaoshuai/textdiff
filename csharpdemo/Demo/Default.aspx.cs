﻿using System;
using Helpers;

namespace Demo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text1 = @"<p><i>This is</i> some sample text to <strong>demonstrate</strong> the capability of the <strong>HTML diff tool</strong>.</p>
                                <p>It is based on the <b>Ruby</b> implementation found <a href='http://github.com/myobie/htmldiff'>here</a>. Note how the link has no tooltip</p>
                                <p>What about a number change: 123456?</p>
                                <table cellpadding='0' cellspacing='0'>
                                <tr><td>Some sample text</td><td>Some sample value</td></tr>
                                <tr><td>Data 1 (this row will be removed)</td><td>Data 2</td></tr>
                                </table>
                                Here is a number 2 32";

            string text2 = @"<p>This is some sample <strong>text to</strong> demonstrate the awesome capabilities of the <strong>HTML <u>diff</u> tool</strong>.</p><br/><br/>Extra spacing here that was not here before.
                                <p>It is <i>based</i> on the Ruby implementation found <a title='Cool tooltip' href='http://github.com/myobie/htmldiff'>here</a>. Note how the link has a tooltip now and the HTML diff algorithm has preserved formatting.</p>
                                <p>What about a number change: 123356?</p>
                                <table cellpadding='0' cellspacing='0'>
                                <tr><td>Some sample <strong>bold text</strong></td><td>Some sample value</td></tr>
                                </table>
                                Here is a number 2 <sup>32</sup>";

            this.text1Literal.Text = text1;
            this.text2Literal.Text = text2;
            this.resultLiteral.Text = HtmlDiff.Execute(text1, text2);
        }
    }
}
