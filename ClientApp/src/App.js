import React, { useState, useEffect } from 'react';
import axios from 'axios';

import { WidgetTable } from './components/WidgetTable';

export const App = () => {

  const [ widgets, setWidgets ] = useState([]);

  useEffect(() => {

    axios
      .get('/api/widgets')
      .then(({ data: downloadedWidgets }) =>
        setWidgets(downloadedWidgets));

  }, []);

  return <WidgetTable widgets={widgets} />;
};
