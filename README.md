# LiveJournalPoster
Simple library for add new posts to Livejournal via XML-RPC protocol.

### Usage: 

1. Install package BlackEric001.LjPoster
2. Fill live journal credentials an post info:

UserPassword up = new UserPassword();
up.username = "test0001x";
up.hpassword = "md5 password hash";

Post post = new Post();
post.Content = "test";
post.TagList = "������";
post.Title = "test";

Poster ljPoster = new Poster();
ljPoster.MakeNewPost(up, post);


