import { data } from './data.js';
import { templateLoader } from './template-loader.js';

var router = (() => {
    let navigo;

    function init() {
        navigo = new Navigo(null, false);

        navigo
            .on('/threads/:id', (route) => {
                Promise.all([data.threads.getById(route.id), templateLoader.get('messages')])
                    .then(([data, template]) => $('#content').append(template(data)))
                    .catch(console.log);
            })
            .on('/threads', () => {
                Promise.all([data.threads.get(), templateLoader.get('threads')])
                    .then(([data, template]) => $('#content').html(template(data)))
                    .catch(console.log);
            })
            .on('/gallery', () => {
                Promise.all([data.gallery.get(), templateLoader.get('gallery')])
                    .then(([data, template]) => $('#content').html(template(data)))
                    .catch(console.log);
            });
    }

    return {
        init
    }
})();

export { router };