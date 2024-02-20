import React, { Component, Fragment, lazy, Suspense } from 'react';
import { Router, Route } from 'react-router-dom';
import { createBrowserHistory } from 'history';

export const history = createBrowserHistory();

export const itemRoute = {
    home: "/",
    blog: "/blog",
}

export const routes = <Router history={history}>
    <Route exact path={itemRoute.home} render={() => <div>Home</div>} />
    <Route exact path={itemRoute.blog} children={() => <div>Blog</div>} />
</Router>