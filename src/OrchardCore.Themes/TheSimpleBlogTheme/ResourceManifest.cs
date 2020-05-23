using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheSimpleBlogTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            // Javascript

            manifest
                .DefineScript("thesimpleblogtheme-vendor-jquery")
                .SetUrl("~/TheSimpleBlogTheme/vendor/jquery/jquery-2.2.4.min.js",
                "~/TheSimpleBlogTheme/vendor/jquery/jquery-2.2.4.js")
                .SetCdn("https://code.jquery.com/jquery-2.2.4.min.js",
                "https://code.jquery.com/jquery-2.2.4.js")
                .SetCdnIntegrity("sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44=",
                "sha256-iT6Q9iMJYuQiMWNd9lDyBUStIq/8PuOW33aOqmvFpqI=")
                .SetVersion("2.2.4");

            manifest
                .DefineScript("thesimpleblogtheme-vendor-bootstrap-js")
                .SetUrl("~/TheSimpleBlogTheme/vendor/bootstrap/js/bootstrap.min.js",
                "~/TheSimpleBlogTheme/vendor/bootstrap/js/bootstrap.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.min.js",
                "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.js")
                .SetCdnIntegrity("sha256-U5ZEeKfGNOja007MMD3YBI0A3OSZOQbeG6z2f2Y0hu8=",
                "sha256-Cr6N6zNN4bp0OwTQOZ6Z66M2r+2dpy/EwKMCyZ+SOMg=")
                .SetVersion("3.3.7");

            manifest
                .DefineScript("thesimpleblogtheme-vendor-jquery-ajaxchimp")
                .SetUrl("~/TheSimpleBlogTheme/vendor/jquery/jquery.ajaxchimp.min.js",
                "~/TheSimpleBlogTheme/vendor/jquery/jquery.ajaxchimp.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jquery-ajaxchimp/1.3.0/jquery.ajaxchimp.min.js",
                "https://cdnjs.cloudflare.com/ajax/libs/jquery-ajaxchimp/1.3.0/jquery.ajaxchimp.js")
                .SetCdnIntegrity("sha256-LcyfaRZnHuDuTF98e28TxRkYm2XTcaOTCcDZW3kFDCg=",
                "sha256-fgVzT21oD+yJOJDeQoq1PgdxfZdDlVHdsLqSiDtH+WE=")
                .SetVersion("1.3.0");

            manifest
                .DefineScript("thesimpleblogtheme-vendor-magnific-popup-js")
                .SetUrl("~/TheSimpleBlogTheme/vendor/magnific-popup/js/jquery.magnific-popup.min.js",
                "~/TheSimpleBlogTheme/vendor/magnific-popup/js/jquery.magnific-popup.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js",
                "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.js")
                .SetCdnIntegrity("sha256-P93G0oq6PBPWTP1IR8Mz/0jHHUpaWL0aBJTKauisG7Q=",
                "sha256-wk7QMTzYE7BJvko9BsywPzRmKzhCtIQKTuN6/B9sRmw=")
                .SetVersion("1.1.0");

            //manifest
            //    .DefineScript("thesimpleblogtheme-vendor-owl-carousel")
            //    .SetUrl("~/TheSimpleBlogTheme/vendor/owl-carousel/owl.carousel.min.js",
            //    "~/TheSimpleBlogTheme/vendor/owl-carousel/owl.carousel.js")
            //    .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js",
            //    "https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.js")
            //    .SetCdnIntegrity("sha256-pTxD+DSzIwmwhOqTFN+DB+nHjO4iAsbgfyFq5K5bcE0=",
            //    "sha256-251s88HEsEfGL2RufZmRwGohKTHDYr9T+aJAazDwlGY=")
            //    .SetVersion("2.3.4");

            // CSS

            manifest
                .DefineStyle("thesimpleblogtheme-vendor-bootstrap-css")
                .SetUrl("~/TheSimpleBlogTheme/vendor/bootstrap/css/bootstrap.min.css",
                "~/TheSimpleBlogTheme/vendor/bootstrap/css/bootstrap.css")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css",
                "https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css")
                .SetCdnIntegrity("sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u",
                "sha384-yzOI+AGOH+8sPS29CtL/lEWNFZ+HKVVyYxU0vjId0pMG6xn7UMDo9waPX5ImV0r6")
                .SetVersion("3.3.7");

            manifest
                .DefineStyle("thesimpleblogtheme-vendor-font-awesome")
                .SetUrl("~/TheSimpleBlogTheme/vendor/font-awesome/font-awesome.min.css",
                "~/TheSimpleBlogTheme/vendor/font-awesome/font-awesome.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css",
                "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css")
                .SetCdnIntegrity("sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN",
                "sha256-NuCn4IvuZXdBaFKJOAcsU2Q3ZpwbdFisd5dux4jkQ5w=")
                .SetVersion("4.7.0");

            manifest
                .DefineStyle("thesimpleblogtheme-vendor-simple-line-icons")
                .SetUrl("~/TheSimpleBlogTheme/vendor/simple-line-icons/simple-line-icons.min.css",
                "~/TheSimpleBlogTheme/vendor/simple-line-icons/simple-line-icons.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/simple-line-icons/2.4.1/css/simple-line-icons.min.css",
                "https://cdnjs.cloudflare.com/ajax/libs/simple-line-icons/2.4.1/css/simple-line-icons.css")
                .SetCdnIntegrity("sha384-BvkleCPDDuKeqW3+qr+UD98bFZ7fTX9IKmYRhQb7Yj6JXDrHblWWwbs3p8gsEyxx",
                "sha256-q5+FXlQok94jx7fkiX65EGbJ27/qobH6c6gmhngztLE=")
                .SetVersion("2.4.1");

            manifest
                .DefineStyle("thesimpleblogtheme-vendor-magnific-popup-css")
                .SetUrl("~/TheSimpleBlogTheme/vendor/magnific-popup/css/magnific-popup.min.css",
                "~/TheSimpleBlogTheme/vendor/magnific-popup/css/magnific-popup.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css",
                "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.css")
                .SetCdnIntegrity("sha256-PZLhE6wwMbg4AB3d35ZdBF9HD/dI/y4RazA3iRDurss=",
                "sha256-RdH19s+RN0bEXdaXsajztxnALYs/Z43H/Cdm1U4ar24=")
                .SetVersion("1.1.0");

        }
    }
}
