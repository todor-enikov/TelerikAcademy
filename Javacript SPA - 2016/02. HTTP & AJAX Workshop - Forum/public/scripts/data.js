var data = (function() {
    const USERNAME_STORAGE_KEY = 'username-key';

    // start users
    function userLogin(user) {
        localStorage.setItem(USERNAME_STORAGE_KEY, user);
        return Promise.resolve(user);
    }

    function userLogout() {
        localStorage.removeItem(USERNAME_STORAGE_KEY);
        return Promise.resolve();
    }

    function userGetCurrent() {
        return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
    }
    // end users

    // start threads
    function threadsGet() {
        return new Promise((resolve, reject) => {
            $.getJSON('api/threads')
                .done(resolve)
                .fail(reject);
        });
    }

    function threadsAdd(title) {
        var apiUrl = 'api/threads';
        //titleOfThread = $('#input-add-thread').val();
        //var usernameOfTread = $('#span-username').text;
        var body = {
            title: title,
            username: 'anonymous'
        };
        var promisePost = new Promise((resolve, reject) => {
            $.ajax({
                    url: apiUrl,
                    method: "POST",
                    contentType: "application/json",
                    data: JSON.stringify(body),
                }).done(resolve)
                .fail(reject);
        });

        return promisePost;
    }

    //   function threadsAdd(title) {
    //   return new Promise((resolve, reject) => {
    //       let username = userGetCurrent()
    //           .then((username) => {
    //               let body = { title, username };

    //               $.ajax({
    //                   type: 'POST',
    //                   url: 'api/threads',
    //                   data: JSON.stringify(body),
    //                   contentType: 'application/json'
    //               }).done(data => resolve(data))
    //                 .fail(err => reject(err));
    //           });
    //   });
    // }

    function threadById(id) {
        var apiUrl = 'api/threads/' + id;
        var promiseGetById = new Promise((resolve, reject) => {
            $.ajax({
                    url: apiUrl,
                    method: 'GET',
                    contentType: 'application/json'
                }).done(resolve)
                .fail(reject);
        });
        return promiseGetById;
    }

    function threadsAddMessage(threadId, content) {
        var apiUrl = 'api/threads/' + threadId + '/messages';
        var body = {
            username: 'anonymous',
            content: content
        };

        var promiseMessage = new Promise((resolve, reject) => {
            $.ajax({
                    url: apiUrl,
                    method: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(body)
                }).done(resolve)
                .fail(reject);
        });

        return promiseMessage;
    }
    // end threads

    // start gallery
    function galleryGet() {
        const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;
        var promiseGallery = new Promise((resolve, reject) => {
            $.getJSON(REDDIT_URL)
                .done(resolve)
                .fail(reject);
        });
        return promiseGallery;
    }
    // end gallery

    return {
        users: {
            login: userLogin,
            logout: userLogout,
            current: userGetCurrent
        },
        threads: {
            get: threadsGet,
            add: threadsAdd,
            getById: threadById,
            addMessage: threadsAddMessage
        },
        gallery: {
            get: galleryGet,
        }
    }
})();