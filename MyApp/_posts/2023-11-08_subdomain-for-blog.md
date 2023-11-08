---
title: Setting up my Markdown blogging site with Razor SSG 
summary: ASP.NET Razor pages hurt my brain, fortunately Razor SSG has been the perfect platform for me to learn the basics.
author: Ben Norton
tags: [razor, markdown]
image: https://i.ytimg.com/vi/MRQMBrXi5Sc/maxresdefault.jpg
---

# I spent hours trying to Get the Index page to redirect to the blog

__How hard can it be?__

<br>

Turns out it is hard. And it was because I misunderstood  how sites are built when hosted at `"username".github.io`.

When I added a `onGet()` function to the index page, it was to redirect to the Blog.cshtml page through a pattern matching string with `LocalRedirectResult("/blog")` method.

This yielded the result I wanted in my development environment. But When hosted on Github Pages, I noticed that the root page had changed.

`benjinotn.github.io/razor-blog`

What to do now! The `onGet()` command doesn't trigger because razor-blog is in the way! (I don't know how each to describe this).

<br>
## Plan B: Delete Index and replace it with Blog

I thought changing Blog.cshtml to include `@model('/')` would fix it, now the default page opens the blog! But spoilers! Another problem occurs in production!

When changing the navbar link to this new '/' location, the root isn't referenced correctly, resulting in the dreaded 404. 

![404 Error sign](https://studio.uxpincdn.com/studio/wp-content/uploads/2023/03/404-page-best-practice.png.webp)

### With a hearthy sigh, I realised I had to do what no one wants to do...
<br>
## Plan C: Spend Money

I spent $9 on a domain name. Feeling fairly sorry for myself at this stage. I added it to the settings `page` tab on github and added a CNAME configuration to the DNS so it functioned as an alias. I'm just very __lucky__ that the build.yml script that was included in the razor SSG template had conditions for building with custom domains.

No weird `razor-blog` extension, no failed navbar references, The blog is default! And it is hosted [Here!](/)

My next plans are to add commenting, user functionality for some discussion. But judging by the speed of this features implementation, it won't be here any time soon!
