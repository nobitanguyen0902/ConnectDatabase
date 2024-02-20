import * as ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import { routes } from './routes';

function renderApp() {
    ReactDOM.render(
        <BrowserRouter children={routes} />,
    document.getElementById('root')
);
}

renderApp();

// reportWebVitals();