# LiveJournalPoster
Simple library for add new posts to Livejournal via XML-RPC protocol.

## Usage: 

1. Install nuget package "Install-Package BlackEric001.LjPoster -Version 0.0.2"
2. Fill live journal credentials an post info:
3. Get iframe for posting video from youtube:
   var iframe = LjPoster.Helpers.CommonHelper.GetYoutubeIframe("https://youtu.be/OtzSlfQ2H08");

##
    UserPassword up = new UserPassword();
    up.username = "user_name_without_domain";
    up.hpassword = "md5 password hash";
    Post post = new Post();
    post.Content = "test";
    post.TagList = "space";
    post.Title = "test";
    Poster ljPoster = new Poster();
    ljPoster.MakeNewPost(up, post);




