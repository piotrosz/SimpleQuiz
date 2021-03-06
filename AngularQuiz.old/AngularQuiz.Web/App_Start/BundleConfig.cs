﻿using System.Web;
using System.Web.Optimization;

namespace AngularQuiz.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.slate.css",
                      "~/Content/site.css",
                      "~/Content/toaster.css",
                      "~/Content/loading-bar.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/Scripts/angular.js",
                    //"~/Scripts/angular-route.js",
                    "~/Scripts/angular-ui-router.js",
                    "~/Scripts/angular-resource.js",
                    "~/Scripts/angular-animate.js",
                    "~/Scripts/toaster.js",
                    "~/Scripts/ui-bootstrap-0.10.0.js",
                    "~/Scripts/ui-bootstrap-tpls-0.10.0.js",
                    "~/Scripts/loading-bar.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/underscore").Include(
                "~/Scripts/underscore.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                    "~/app/directives/*.js",    
                    "~/app/app.js",
                    "~/app/util.js", 
                    "~/app/filters/*.js",
                    "~/app/controllers/*.js",
                    "~/app/controllers/question/*.js",
                    "~/app/controllers/quiz/*.js",
                    "~/app/controllers/package/*.js",
                    "~/app/controllers/question/*.js",
                    "~/app/services/*.js"
                ));
        }
    }
}
