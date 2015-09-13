


<!DOCTYPE html>
<html lang="en" class=" is-copy-enabled">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta name="viewport" content="width=1020">
    
    
    <title>TelerikAcademy/AbstractFactory.md at master · g-yonchev/TelerikAcademy</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="g-yonchev/TelerikAcademy" name="twitter:title" /><meta content="TelerikAcademy - Homeworks at Telerik Akademy 2015-2016" name="twitter:description" /><meta content="https://avatars0.githubusercontent.com/u/10466562?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars0.githubusercontent.com/u/10466562?v=3&amp;s=400" property="og:image" /><meta content="g-yonchev/TelerikAcademy" property="og:title" /><meta content="https://github.com/g-yonchev/TelerikAcademy" property="og:url" /><meta content="TelerikAcademy - Homeworks at Telerik Akademy 2015-2016" property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/MTA1NTMyMTA6NGQwM2NlNGMwMDUxZjk2MzQyNjcxMTkzZjBkZTM2MDA6NWZhN2I3ODBkZmQyMzFlNmE4OGJjM2M3Mjc0YTZkZjgxMTYyNGY1MGRhYjI4ZWVjZjI4OWI5NTk5ZDczYjZhNw==--e6c179797251382a9a47c69f043d1335be91638d">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>

    <meta name="google-site-verification" content="KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU">
        <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="C1975018:1495:1E3DF77:55F5BFF3" name="octolytics-dimension-request_id" /><meta content="10553210" name="octolytics-actor-id" /><meta content="tokera" name="octolytics-actor-login" /><meta content="3abd66fe457658c34dc7aaf332d91477deb8c9d2d47a5f76edb9bb38063fee14" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" data-pjax-transient="true" name="analytics-event" />
    <meta class="js-ga-set" name="dimension1" content="Logged In">
      <meta class="js-ga-set" name="dimension4" content="Current repo nav">
    <meta name="is-dotcom" content="true">
        <meta name="hostname" content="github.com">
    <meta name="user-login" content="tokera">

      <link rel="mask-icon" href="https://assets-cdn.github.com/pinned-octocat.svg" color="#4078c0">
      <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">

    <!-- </textarea> --><!-- '"` --><meta content="authenticity_token" name="csrf-param" />
<meta content="bWxyUC/NtElTl4SNpB/o41MBukOzNuyJsvFTtbDjgQ+79AJ/rRvmzRhevo8nnxPkj7t4+SDO/1hb1fuOsuaGbg==" name="csrf-token" />
    <meta content="feb933fbf08edb5ad78024bf6a22213bf32716cf" name="form-nonce" />

    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github-a14e3d6410d6fd1b2fa98e4e859a3bd1fb7c3b71f16c511481f068705c04d6a5.css" media="all" rel="stylesheet" />
    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github2-ddeb1c89541d4a66272d529e53eea795596f88651e3227883c8d99a59d7e0ec5.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="e025af83f90d59b969df6cecbfb86c10">

      
  <meta name="description" content="TelerikAcademy - Homeworks at Telerik Akademy 2015-2016">
  <meta name="go-import" content="github.com/g-yonchev/TelerikAcademy git https://github.com/g-yonchev/TelerikAcademy.git">

  <meta content="10466562" name="octolytics-dimension-user_id" /><meta content="g-yonchev" name="octolytics-dimension-user_login" /><meta content="29325094" name="octolytics-dimension-repository_id" /><meta content="g-yonchev/TelerikAcademy" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="29325094" name="octolytics-dimension-repository_network_root_id" /><meta content="g-yonchev/TelerikAcademy" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/g-yonchev/TelerikAcademy/commits/master.atom" rel="alternate" title="Recent Commits to TelerikAcademy:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>

    
    
    



      <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/g-yonchev/TelerikAcademy/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <label class="js-chromeless-input-container form-control">
    <div class="scope-badge">This repository</div>
    <input type="text"
      class="js-site-search-focus js-site-search-field is-clearable chromeless-input"
      data-hotkey="s"
      name="q"
      placeholder="Search"
      aria-label="Search this repository"
      data-global-scope-placeholder="Search GitHub"
      data-repo-scope-placeholder="Search"
      tabindex="1"
      autocapitalize="off">
  </label>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item">
          <a href="/pulls" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:pulls context:user" data-hotkey="g p" data-selected-links="/pulls /pulls/assigned /pulls/mentioned /pulls">
            Pull requests
</a>        </li>
        <li class="header-nav-item">
          <a href="/issues" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:issues context:user" data-hotkey="g i" data-selected-links="/issues /issues/assigned /issues/mentioned /issues">
            Issues
</a>        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com/" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item">
      <span class="js-socket-channel js-updatable-content"
        data-channel="notification-changed:tokera"
        data-url="/notifications/header">
      <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
          <span class="mail-status all-read"></span>
          <span class="octicon octicon-bell"></span>
</a>  </span>

  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link tooltipped tooltipped-s js-menu-target" href="/new"
       aria-label="Create new…"
       data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus left"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu dropdown-menu-sw">
        
<a class="dropdown-item" href="/new" data-ga-click="Header, create new repository">
  New repository
</a>


  <a class="dropdown-item" href="/organizations/new" data-ga-click="Header, create new organization">
    New organization
  </a>



  <div class="dropdown-divider"></div>
  <div class="dropdown-header">
    <span title="g-yonchev/TelerikAcademy">This repository</span>
  </div>
    <a class="dropdown-item" href="/g-yonchev/TelerikAcademy/issues/new" data-ga-click="Header, create new issue">
      New issue
    </a>

      </ul>
    </div>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name tooltipped tooltipped-s js-menu-target" href="/tokera"
       aria-label="View profile and more"
       data-ga-click="Header, show menu, icon:avatar">
      <img alt="@tokera" class="avatar" height="20" src="https://avatars2.githubusercontent.com/u/10553210?v=3&amp;s=40" width="20" />
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <div class="dropdown-menu dropdown-menu-sw">
        <div class="dropdown-header header-nav-current-user css-truncate">
          Signed in as <strong class="css-truncate-target">tokera</strong>
        </div>
        <div class="dropdown-divider"></div>

        <a class="dropdown-item" href="/tokera" data-ga-click="Header, go to profile, text:your profile">
          Your profile
        </a>
        <a class="dropdown-item" href="/stars" data-ga-click="Header, go to starred repos, text:your stars">
          Your stars
        </a>
        <a class="dropdown-item" href="/explore" data-ga-click="Header, go to explore, text:explore">
          Explore
        </a>
        <a class="dropdown-item" href="https://help.github.com" data-ga-click="Header, go to help, text:help">
          Help
        </a>
        <div class="dropdown-divider"></div>

        <a class="dropdown-item" href="/settings/profile" data-ga-click="Header, go to settings, icon:settings">
          Settings
        </a>

        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/logout" class="logout-form" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="L9R4ceG+WAoUhQMHo9uGYkC7yCogqd2qTz8xCIEvWtgNeyEg4apGy4YUqLLhe1WnK0eSVVH+MR+uULfKZsSwBw==" /></div>
          <button class="dropdown-item dropdown-signout" data-ga-click="Header, sign out, icon:logout">
            Sign out
          </button>
</form>      </div>
    </div>
  </li>
</ul>


    
  </div>
</div>

      

      


    <div id="start-of-content" class="accessibility-aid"></div>

    <div id="js-flash-container">
</div>


    <div role="main" class="main-content">
        <div itemscope itemtype="http://schema.org/WebPage">
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">

        <div class="clearfix">
          
<ul class="pagehead-actions">

  <li>
      <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="slSzJP3ghMjyavV+WuHWbxKkky//aQLlXbVPmhRCWEA/v1vh7MSuTPZEhnLf7DXNvAkYx5FRFqk7tHWyRuNfLQ==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="29325094" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/g-yonchev/TelerikAcademy/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Watch
          </span>
        </a>
        <a class="social-count js-social-count" href="/g-yonchev/TelerikAcademy/watchers">
          2
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/unstar" class="js-toggler-form starred js-unstar-button" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ZyohZcz2Yi5xRYxm1M0rfGtySO7vKN73JLcP7kGaDLpJfAQZRJeyWPlu4LYTtduQrdsgap3xvgnHKCVlRjq0Hw==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar g-yonchev/TelerikAcademy"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/g-yonchev/TelerikAcademy/stargazers">
          4
        </a>
</form>
    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/star" class="js-toggler-form unstarred js-star-button" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="s6OiXlCUWf92TLAwPg3OK0y11q4dRCy3eb1z7LHrZygf6CYVnLuDruqdjov9AfUzZEiDxSvprpgMCLIAy1HlTw==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star g-yonchev/TelerikAcademy"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/g-yonchev/TelerikAcademy/stargazers">
          4
        </a>
</form>  </div>

  </li>

        <li>
          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/fork" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="PgS98QVkXSH76EF26w8/lf+FtbDohZM2lR3CgAekxRcfdcthFYk5y1HM1tlX6TOjr0qmTx8MQdHoaD+yCowSwA==" /></div>
            <button
                type="submit"
                class="btn btn-sm btn-with-count"
                data-ga-click="Repository, show fork modal, action:blob#show; text:Fork"
                title="Fork your own copy of g-yonchev/TelerikAcademy to your account"
                aria-label="Fork your own copy of g-yonchev/TelerikAcademy to your account">
              <span class="octicon octicon-repo-forked"></span>
              Fork
            </button>
            <a href="/g-yonchev/TelerikAcademy/network" class="social-count">5</a>
</form>        </li>

</ul>

          <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public ">
  <span class="mega-octicon octicon-repo"></span>
  <span class="author"><a href="/g-yonchev" class="url fn" itemprop="url" rel="author"><span itemprop="title">g-yonchev</span></a></span><!--
--><span class="path-divider">/</span><!--
--><strong><a href="/g-yonchev/TelerikAcademy" data-pjax="#js-repo-pjax-container">TelerikAcademy</a></strong>

  <span class="page-context-loader">
    <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
  </span>

</h1>

        </div>
      </div>
    </div>

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline ">
        <div class="repository-sidebar clearfix">
          
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/g-yonchev/TelerikAcademy/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/g-yonchev/TelerikAcademy" aria-label="Code" aria-selected="true" class="js-selected-navigation-item selected sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /g-yonchev/TelerikAcademy">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/g-yonchev/TelerikAcademy/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /g-yonchev/TelerikAcademy/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/g-yonchev/TelerikAcademy/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /g-yonchev/TelerikAcademy/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Wiki">
        <a href="/g-yonchev/TelerikAcademy/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g w" data-selected-links="repo_wiki /g-yonchev/TelerikAcademy/wiki">
          <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/g-yonchev/TelerikAcademy/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /g-yonchev/TelerikAcademy/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/g-yonchev/TelerikAcademy/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /g-yonchev/TelerikAcademy/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>
  </ul>


</nav>

            <div class="only-with-full-nav">
                
<div class="js-clone-url clone-url open"
  data-protocol-type="http">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/g-yonchev/TelerikAcademy.git" readonly="readonly" aria-label="HTTPS clone URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="ssh">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:g-yonchev/TelerikAcademy.git" readonly="readonly" aria-label="SSH clone URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="subversion">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/g-yonchev/TelerikAcademy" readonly="readonly" aria-label="Subversion checkout URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



  <div class="clone-options">You can clone with
    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="h2pd7pxea7yYuxD/nkWNEiHvlFWp+n3DkEeUvvM79e8UNCCA5RDHJPpSThqzh5f36giY48P0u8rhnCPzewYSrA==" /></div><button class="btn-link js-clone-selector" data-protocol="http" type="submit">HTTPS</button></form>, <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="JLOfN2Fs95uyj0T4FJIlZ3iGZOp8HEMjAG7DztQzpakNVXmyQIM5JMIwoymeMGE3g8aLn/tks+GJcmXA4qt2rw==" /></div><button class="btn-link js-clone-selector" data-protocol="ssh" type="submit">SSH</button></form>, or <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ZEAZU3cYEmdqKNgYRs/sxJlbfN89k4ggM/8T0qjwzWbK7N9ZQYxomAe24F2IGHyhCOg+w0NP4V8h8YRkovu0Zg==" /></div><button class="btn-link js-clone-selector" data-protocol="subversion" type="submit">Subversion</button></form>.
    <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
      <span class="octicon octicon-question"></span>
    </a>
  </div>
    <a href="https://windows.github.com" class="btn btn-sm sidebar-button" title="Save g-yonchev/TelerikAcademy to your computer and use it in GitHub Desktop." aria-label="Save g-yonchev/TelerikAcademy to your computer and use it in GitHub Desktop.">
      <span class="octicon octicon-desktop-download"></span>
      Clone in Desktop
    </a>

              <a href="/g-yonchev/TelerikAcademy/archive/master.zip"
                 class="btn btn-sm sidebar-button"
                 aria-label="Download the contents of g-yonchev/TelerikAcademy as a zip file"
                 title="Download the contents of g-yonchev/TelerikAcademy as a zip file"
                 rel="nofollow">
                <span class="octicon octicon-cloud-download"></span>
                Download ZIP
              </a>
            </div>
        </div>
        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>

          

<a href="/g-yonchev/TelerikAcademy/blob/450720cb99274a1fd6397285c203241b195b9f7a/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:3452adbd77f1d25f4154c9eb192167da -->

  <div class="file-navigation js-zeroclipboard-container">
    
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <i>Branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab" role="tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab" role="tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches" role="menu">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/g-yonchev/TelerikAcademy/blob/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

    <div class="btn-group right">
      <a href="/g-yonchev/TelerikAcademy/find/master"
            class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-nw"
            data-pjax
            data-hotkey="t"
            aria-label="Quickly jump between files">
        <span class="octicon octicon-list-unordered"></span>
      </a>
      <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </div>

    <div class="breadcrumb js-zeroclipboard-target">
      <span class="repo-root js-repo-root"><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/g-yonchev/TelerikAcademy" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">TelerikAcademy</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/g-yonchev/TelerikAcademy/tree/master/Homeworks" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Homeworks</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/g-yonchev/TelerikAcademy/tree/master/Homeworks/High-Quality-Code" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">High-Quality-Code</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/g-yonchev/TelerikAcademy/tree/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">19. Design Patterns</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/g-yonchev/TelerikAcademy/tree/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Creational Design Patterns</span></a></span><span class="separator">/</span><strong class="final-path">AbstractFactory.md</strong>
    </div>
  </div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="@g-yonchev" class="avatar" height="24" src="https://avatars1.githubusercontent.com/u/10466562?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/g-yonchev" rel="author">g-yonchev</a></span>
        <time datetime="2015-09-13T17:38:58Z" is="relative-time">Sep 13, 2015</time>
        <div class="commit-title">
            <a href="/g-yonchev/TelerikAcademy/commit/2aeb89d711f84756626d4c9da69e696931f4e105" class="message" data-pjax="true" title="Update AbstractFactory.md">Update AbstractFactory.md</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>1</strong>
           contributor
        </a>
      </p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header" data-facebox-id="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list" data-facebox-id="facebox-description">
          <li class="facebox-user-list-item">
            <img alt="@g-yonchev" height="24" src="https://avatars1.githubusercontent.com/u/10466562?v=3&amp;s=48" width="24" />
            <a href="/g-yonchev">g-yonchev</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
  <div class="file-actions">

    <div class="btn-group">
      <a href="/g-yonchev/TelerikAcademy/raw/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="btn btn-sm " id="raw-url">Raw</a>
        <a href="/g-yonchev/TelerikAcademy/blame/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
      <a href="/g-yonchev/TelerikAcademy/commits/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="btn btn-sm " rel="nofollow">History</a>
    </div>

      <a class="octicon-btn tooltipped tooltipped-nw"
         href="https://windows.github.com"
         aria-label="Open this file in GitHub Desktop"
         data-ga-click="Repository, open with desktop, type:windows">
          <span class="octicon octicon-device-desktop"></span>
      </a>

        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/edit/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="inline-form js-update-url-with-hash" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="K82rTKMlry6XOBEcyW9w814OpNaSs1pIJE/O6zYvBp5pNK2IOIQnpY34rN8jgtiEJPqnmWRjKsisXcPb3B0pfA==" /></div>
          <button class="octicon-btn tooltipped tooltipped-nw" type="submit"
            aria-label="Fork this project and edit the file" data-hotkey="e" data-disable-with>
            <span class="octicon octicon-pencil"></span>
          </button>
</form>        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/g-yonchev/TelerikAcademy/delete/master/Homeworks/High-Quality-Code/19.%20Design%20Patterns/Creational%20Design%20Patterns/AbstractFactory.md" class="inline-form" data-form-nonce="feb933fbf08edb5ad78024bf6a22213bf32716cf" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ejfajoyu7eCkHFo3hlLYEtfBZVK3Ujh2GRIgoN5v1kuH6vjikKPYHh0E8kQ2gtwhnxtM8w0U6Ow5QRo786x49g==" /></div>
          <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-nw" type="submit"
            aria-label="Fork this project and delete the file" data-disable-with>
            <span class="octicon octicon-trashcan"></span>
          </button>
</form>  </div>

  <div class="file-info">
      228 lines (193 sloc)
      <span class="file-info-divider"></span>
    6.52 KB
  </div>
</div>

  
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-abstract-factory" class="anchor" href="#abstract-factory" aria-hidden="true"><span class="octicon octicon-link"></span></a>Abstract Factory</h1>

<h2><a id="user-content-Намерение" class="anchor" href="#Намерение" aria-hidden="true"><span class="octicon octicon-link"></span></a>Намерение</h2>

<p>Осигурява интерфейс за създаване на семейства от обекти, които са свързани и зависими помежду си, без да се посочват техните конкретни класове.
(Също известен като Kit)</p>

<h2><a id="user-content-Мотив" class="anchor" href="#Мотив" aria-hidden="true"><span class="octicon octicon-link"></span></a>Мотив</h2>

<p>С цел да се предотврати модуларизацията се използва този шаблон. 
Също се използва в системи, които често подлежат на промени.</p>

<h2><a id="user-content-Участници" class="anchor" href="#Участници" aria-hidden="true"><span class="octicon octicon-link"></span></a>Участници</h2>

<h4><a id="user-content-abstract-factory-1" class="anchor" href="#abstract-factory-1" aria-hidden="true"><span class="octicon octicon-link"></span></a>Abstract Factory:</h4>

<p>Декларира интерфейс за операциите по създаването на абстрактни продукти.</p>

<h4><a id="user-content-concrete-factory" class="anchor" href="#concrete-factory" aria-hidden="true"><span class="octicon octicon-link"></span></a>Concrete Factory:</h4>

<p>Имплементира опериациите, по които ще се създават конкретните продукти.</p>

<h4><a id="user-content-abstract-product" class="anchor" href="#abstract-product" aria-hidden="true"><span class="octicon octicon-link"></span></a>Abstract Product:</h4>

<p>Декларира интерфейс за даден тип обект.</p>

<h4><a id="user-content-concrete-product" class="anchor" href="#concrete-product" aria-hidden="true"><span class="octicon octicon-link"></span></a>Concrete Product:</h4>

<p>Дефинира конкретния обект, който ще бъде създаден от конкретната фабрика.
Имплементира Abstract Product.</p>

<h4><a id="user-content-client" class="anchor" href="#client" aria-hidden="true"><span class="octicon octicon-link"></span></a>Client:</h4>

<p>Използва само интерфейси, декларирани от Abstract Factory и Abstract Product.</p>

<h2><a id="user-content-Приложимост" class="anchor" href="#Приложимост" aria-hidden="true"><span class="octicon octicon-link"></span></a>Приложимост</h2>

<p>Използвайте шаблона Abstract Factory, когато:</p>

<ul>
<li>  Дадена система трябва да бъде независима от това как нейните продукти създадени.<br></li>
<li>  Системата трябва да бъде конфигурирана с една от множеството семейства от обекти.</li>
<li>  Когато искаш да предоставиш клас библиотека от обекти, но искаш да бъдат известни само техните интерфейси, а не тяхните имплементации.</li>
</ul>

<h2><a id="user-content-Свързани-шаблони" class="anchor" href="#Свързани-шаблони" aria-hidden="true"><span class="octicon octicon-link"></span></a>Свързани шаблони</h2>

<p>Abstract Factory класовете са често имплементирани с Factory Method шаблонът, но те могат също така да бъдат имплементирани, използвайки Prototype шаблона.
Concrete Factory е чесно Sigleton.</p>

<h2><a id="user-content-Структура" class="anchor" href="#Структура" aria-hidden="true"><span class="octicon octicon-link"></span></a>Структура</h2>

<p><a href="/g-yonchev/TelerikAcademy/blob/master/Homeworks/High-Quality-Code/19. Design Patterns/Creational Design Patterns/schemes/structures/abstract-factory-structure.png" target="_blank"><img src="/g-yonchev/TelerikAcademy/raw/master/Homeworks/High-Quality-Code/19. Design Patterns/Creational Design Patterns/schemes/structures/abstract-factory-structure.png" alt="alt text" style="max-width:100%;"></a></p>

<h2><a id="user-content-Пример" class="anchor" href="#Пример" aria-hidden="true"><span class="octicon octicon-link"></span></a>Пример</h2>

<p>Abstract Factory за създаване на заици</p>

<p><a href="/g-yonchev/TelerikAcademy/blob/master/Homeworks/High-Quality-Code/19. Design Patterns/Creational Design Patterns/schemes/diagrams/abstract-factory-classdiagram.png" target="_blank"><img src="/g-yonchev/TelerikAcademy/raw/master/Homeworks/High-Quality-Code/19. Design Patterns/Creational Design Patterns/schemes/diagrams/abstract-factory-classdiagram.png" alt="alt abstract-factory-classdiagram" style="max-width:100%;"></a></p>

<h6><a id="user-content-abstract-bunny" class="anchor" href="#abstract-bunny" aria-hidden="true"><span class="octicon octicon-link"></span></a>Abstract Bunny</h6>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">abstract</span> <span class="pl-k">class</span> <span class="pl-en">Bunny</span>
{
    <span class="pl-k">protected</span> <span class="pl-k">abstract</span> <span class="pl-k">string</span> <span class="pl-en">Habitation</span> { <span class="pl-k">get</span>; }
    <span class="pl-k">protected</span> <span class="pl-k">string</span> <span class="pl-en">Name</span> { <span class="pl-k">get</span>; <span class="pl-k">set</span>; }
    <span class="pl-k">protected</span> <span class="pl-k">double</span> <span class="pl-en">Weight</span> { <span class="pl-k">get</span>; <span class="pl-k">set</span>; }
    <span class="pl-k">protected</span> <span class="pl-k">string</span> <span class="pl-en">Color</span> { <span class="pl-k">get</span>; <span class="pl-k">set</span>; }
    <span class="pl-k">protected</span> List&lt;<span class="pl-k">string</span>&gt; <span class="pl-en">Foods</span> { <span class="pl-k">get</span>; <span class="pl-k">set</span>; }

    <span class="pl-k">protected</span> <span class="pl-en">Bunny</span>(<span class="pl-k">string</span> <span class="pl-smi">name</span>, <span class="pl-k">double</span> <span class="pl-smi">weight</span>, <span class="pl-k">string</span> <span class="pl-smi">color</span>, List&lt;string&gt; foods)
    {
        <span class="pl-c1">this</span>.Name = name;
        <span class="pl-c1">this</span>.Weight = weight;
        <span class="pl-c1">this</span>.Color = color;
        <span class="pl-c1">this</span>.Foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt;(foods);
    }

    <span class="pl-k">public</span> <span class="pl-k">override</span> <span class="pl-k">string</span> <span class="pl-en">ToString</span>()
    {
        <span class="pl-k">var</span> result = <span class="pl-k">new</span> StringBuilder();
        result.AppendLine(<span class="pl-c1">this</span>.Habitation);
        result.AppendLine(<span class="pl-s"><span class="pl-pds">"</span>Name: <span class="pl-pds">"</span></span> + <span class="pl-c1">this</span>.Name);
        result.AppendLine(<span class="pl-s"><span class="pl-pds">"</span>Weight: <span class="pl-pds">"</span></span> + <span class="pl-c1">this</span>.Weight);
        result.AppendLine(<span class="pl-s"><span class="pl-pds">"</span>Color: <span class="pl-pds">"</span></span> + <span class="pl-c1">this</span>.Color);
        result.AppendLine(<span class="pl-s"><span class="pl-pds">"</span>Foods: <span class="pl-pds">"</span></span> + <span class="pl-k">string</span>.Join(<span class="pl-s"><span class="pl-pds">"</span>, <span class="pl-pds">"</span></span>, <span class="pl-c1">this</span>.Foods));
        <span class="pl-k">return</span> result.ToString();
    }
}</pre></div>

<h6><a id="user-content-abstract-bunny-factory" class="anchor" href="#abstract-bunny-factory" aria-hidden="true"><span class="octicon octicon-link"></span></a>Abstract Bunny Factory</h6>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">abstract</span> <span class="pl-k">class</span> <span class="pl-en">AbstractBunnyFactory</span>
{
    <span class="pl-k">public</span> <span class="pl-k">abstract</span> FemaleBunny <span class="pl-en">MakeFemaleBunny</span>();

    <span class="pl-k">public</span> <span class="pl-k">abstract</span> MaleBunny <span class="pl-en">MakeMaleBunny</span>();

    <span class="pl-k">public</span> <span class="pl-k">abstract</span> BabyBunny <span class="pl-en">MakeBabyBunny</span>();
}</pre></div>

<h6><a id="user-content-bunnies-classes-male-female-and-babby-bunny" class="anchor" href="#bunnies-classes-male-female-and-babby-bunny" aria-hidden="true"><span class="octicon octicon-link"></span></a>Bunnies Classes (Male, Female and Babby Bunny)</h6>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">MaleBunny</span> : <span class="pl-k">Bunny</span>
{
    <span class="pl-k">private</span> <span class="pl-k">readonly</span> <span class="pl-k">string</span> habitation;

    <span class="pl-k">public</span> <span class="pl-en">MaleBunny</span>(<span class="pl-k">string</span> <span class="pl-smi">name</span>, <span class="pl-k">double</span> <span class="pl-smi">weight</span>, <span class="pl-k">string</span> <span class="pl-smi">color</span>, List&lt;string&gt; foods, <span class="pl-k">string</span> <span class="pl-smi">habitation</span>)
        : <span class="pl-c1">base</span>(name, weight, color, foods)
    {
        <span class="pl-c1">this</span>.habitation = habitation;
    }

    <span class="pl-k">protected</span> <span class="pl-k">override</span> <span class="pl-k">string</span> Habitation
    {
        <span class="pl-k">get</span>
        {
            <span class="pl-k">return</span> <span class="pl-k">string</span>.Format(<span class="pl-s"><span class="pl-pds">"</span>Male bunny lives in {0}<span class="pl-pds">"</span></span>, <span class="pl-c1">this</span>.habitation);
        }
    }
}</pre></div>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">FemaleBunny</span> : <span class="pl-k">Bunny</span>
{
    <span class="pl-k">private</span> <span class="pl-k">readonly</span> <span class="pl-k">string</span> habitation;

    <span class="pl-k">public</span> <span class="pl-en">FemaleBunny</span>(<span class="pl-k">string</span> <span class="pl-smi">name</span>, <span class="pl-k">double</span> <span class="pl-smi">weight</span>, <span class="pl-k">string</span> <span class="pl-smi">color</span>, List&lt;string&gt; foods, <span class="pl-k">string</span> <span class="pl-smi">habitation</span>)
        : <span class="pl-c1">base</span>(name, weight, color, foods)
    {
        <span class="pl-c1">this</span>.habitation = habitation;
    }
    <span class="pl-k">protected</span> <span class="pl-k">override</span> <span class="pl-k">string</span> Habitation
    {
        <span class="pl-k">get</span>
        {
            <span class="pl-k">return</span> <span class="pl-k">string</span>.Format(<span class="pl-s"><span class="pl-pds">"</span>Female bunny lives in {0}<span class="pl-pds">"</span></span>, <span class="pl-c1">this</span>.habitation);
        }
    }
}</pre></div>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">BabyBunny</span> : <span class="pl-k">Bunny</span>
{
    <span class="pl-k">private</span> <span class="pl-k">readonly</span> <span class="pl-k">string</span> habitation;

    <span class="pl-k">public</span> <span class="pl-en">BabyBunny</span>(<span class="pl-k">string</span> <span class="pl-smi">name</span>, <span class="pl-k">double</span> <span class="pl-smi">weight</span>, <span class="pl-k">string</span> <span class="pl-smi">color</span>, List&lt;string&gt; foods, <span class="pl-k">string</span> <span class="pl-smi">habitation</span>)
        : <span class="pl-c1">base</span>(name, weight, color, foods)
    {
        <span class="pl-c1">this</span>.habitation = habitation;
    }

    <span class="pl-k">protected</span> <span class="pl-k">override</span> <span class="pl-k">string</span> Habitation
    {
        <span class="pl-k">get</span>
        {
            <span class="pl-k">return</span> <span class="pl-k">string</span>.Format(<span class="pl-s"><span class="pl-pds">"</span>Babby bunny lives in {0}<span class="pl-pds">"</span></span>, <span class="pl-c1">this</span>.habitation);
        }
    }
}</pre></div>

<h6><a id="user-content-bunnies-factories-forest-and-farm" class="anchor" href="#bunnies-factories-forest-and-farm" aria-hidden="true"><span class="octicon octicon-link"></span></a>Bunnies Factories (Forest and Farm)</h6>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">ForestFactory</span> : <span class="pl-k">AbstractBunnyFactory</span>
{
    <span class="pl-k">private</span> <span class="pl-k">const</span> <span class="pl-k">string</span> Name = <span class="pl-s"><span class="pl-pds">"</span>Back Forest<span class="pl-pds">"</span></span>;

    <span class="pl-k">public</span> <span class="pl-k">override</span> FemaleBunny <span class="pl-en">MakeFemaleBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>foxes<span class="pl-pds">"</span></span>, <span class="pl-s"><span class="pl-pds">"</span>small trees<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> female = <span class="pl-k">new</span> FemaleBunny(<span class="pl-s"><span class="pl-pds">"</span>Wild Maria<span class="pl-pds">"</span></span>, <span class="pl-c1">13.2f</span>, <span class="pl-s"><span class="pl-pds">"</span>colorful<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> female;
    }

    <span class="pl-k">public</span> <span class="pl-k">override</span> MaleBunny <span class="pl-en">MakeMaleBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>tigers<span class="pl-pds">"</span></span>, <span class="pl-s"><span class="pl-pds">"</span>elephants<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> male = <span class="pl-k">new</span> MaleBunny(<span class="pl-s"><span class="pl-pds">"</span>Wild Johny<span class="pl-pds">"</span></span>, <span class="pl-c1">23.2f</span>, <span class="pl-s"><span class="pl-pds">"</span>invisible<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> male;
    }

    <span class="pl-k">public</span> <span class="pl-k">override</span> BabyBunny <span class="pl-en">MakeBabyBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>zombies<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> baby = <span class="pl-k">new</span> BabyBunny(<span class="pl-s"><span class="pl-pds">"</span>Unknow<span class="pl-pds">"</span></span>, <span class="pl-c1">21.5f</span>, <span class="pl-s"><span class="pl-pds">"</span>pink<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> baby;
    }
}</pre></div>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">FarmFactory</span> : <span class="pl-k">AbstractBunnyFactory</span>
{
    <span class="pl-k">private</span> <span class="pl-k">const</span> <span class="pl-k">string</span> Name = <span class="pl-s"><span class="pl-pds">"</span>Pesho's Farm<span class="pl-pds">"</span></span>;

    <span class="pl-k">public</span> <span class="pl-k">override</span> FemaleBunny <span class="pl-en">MakeFemaleBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>grass<span class="pl-pds">"</span></span>, <span class="pl-s"><span class="pl-pds">"</span>carrots<span class="pl-pds">"</span></span>, <span class="pl-s"><span class="pl-pds">"</span>little bunny babies<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> female = <span class="pl-k">new</span> FemaleBunny(<span class="pl-s"><span class="pl-pds">"</span>Maria<span class="pl-pds">"</span></span>, <span class="pl-c1">3.2f</span>, <span class="pl-s"><span class="pl-pds">"</span>white<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> female;
    }

    <span class="pl-k">public</span> <span class="pl-k">override</span> MaleBunny <span class="pl-en">MakeMaleBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>grass<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> male = <span class="pl-k">new</span> MaleBunny(<span class="pl-s"><span class="pl-pds">"</span>Pesho<span class="pl-pds">"</span></span>, <span class="pl-c1">3.9f</span>, <span class="pl-s"><span class="pl-pds">"</span>brown<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> male;
    }

    <span class="pl-k">public</span> <span class="pl-k">override</span> BabyBunny <span class="pl-en">MakeBabyBunny</span>()
    {
        <span class="pl-k">var</span> foods = <span class="pl-k">new</span> List&lt;<span class="pl-k">string</span>&gt; { <span class="pl-s"><span class="pl-pds">"</span>small carrots<span class="pl-pds">"</span></span> };
        <span class="pl-k">var</span> baby = <span class="pl-k">new</span> BabyBunny(<span class="pl-s"><span class="pl-pds">"</span>Baby<span class="pl-pds">"</span></span>, <span class="pl-c1">1.0f</span>, <span class="pl-s"><span class="pl-pds">"</span>white-brown<span class="pl-pds">"</span></span>, foods, Name);
        <span class="pl-k">return</span> baby;
    }
}</pre></div>

<h6><a id="user-content-usage" class="anchor" href="#usage" aria-hidden="true"><span class="octicon octicon-link"></span></a>Usage</h6>

<div class="highlight highlight-c#"><pre><span class="pl-k">public</span> <span class="pl-k">static</span> <span class="pl-k">void</span> Main()
    {
        <span class="pl-k">var</span> myForest = <span class="pl-k">new</span> ForestFactory();
        <span class="pl-k">var</span> myFarm = <span class="pl-k">new</span> FarmFactory();

        <span class="pl-k">var</span> bunnies = <span class="pl-k">new</span> List&lt;Bunny&gt; { 
            myForest.MakeBabyBunny(),
            myForest.MakeMaleBunny(),
            myForest.MakeFemaleBunny(),
            myFarm.MakeBabyBunny(),
            myFarm.MakeMaleBunny(),
            myFarm.MakeFemaleBunny()
        };

        <span class="pl-k">foreach</span> (<span class="pl-k">var</span> bunny <span class="pl-k">in</span> bunnies)
        {
            Console.WriteLine(bunny);
        }
    }</pre></div>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="" class="js-jump-to-line-form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" aria-label="Jump to line" autofocus>
    <button type="submit" class="btn">Go</button>
</form></div>

        </div>
      </div>
      <div class="modal-backdrop"></div>
    </div>
  </div>


    </div>

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>
        <li><a href="https://github.com/pricing" data-ga-click="Footer, go to pricing, text:pricing">Pricing</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.08119s from github-fe120-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
        <li><a href="https://help.github.com" data-ga-click="Footer, go to help, text:help">Help</a></li>
    </ul>
  </div>
</div>



    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <button type="button" class="flash-close js-flash-close js-ajax-error-dismiss" aria-label="Dismiss error">
        <span class="octicon octicon-x"></span>
      </button>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-2c67e846b237d12dc49d9ba38bef688797518db6c4fc7ec256caf871623c69e4.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-cdf2812e9b014c7112138481f998b4d18770faa142b62ce3c3223fbf481b6a94.js"></script>
      
      
    <div class="js-stale-session-flash stale-session-flash flash flash-warn flash-banner hidden">
      <span class="octicon octicon-alert"></span>
      <span class="signed-in-tab-flash">You signed in with another tab or window. <a href="">Reload</a> to refresh your session.</span>
      <span class="signed-out-tab-flash">You signed out in another tab or window. <a href="">Reload</a> to refresh your session.</span>
    </div>
  </body>
</html>

