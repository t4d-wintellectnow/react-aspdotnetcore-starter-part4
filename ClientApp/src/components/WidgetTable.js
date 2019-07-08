import React from 'react';

import { widgetsPropType } from '../propTypes/widgets';

export const WidgetTable = ({ widgets }) => {

  return (
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Color</th>
          <th>Quantity</th>
        </tr>
      </thead>
      <tbody>
        {widgets.map(widget => {
          return (
            <tr key={widget.id}>
              <td>{widget.id}</td>
              <td>{widget.name}</td>
              <td>{widget.color}</td>
              <td>{widget.quantity}</td>
            </tr>
          );
        })}
      </tbody>
    </table>
  );

};

WidgetTable.propTypes = {
  widgets: widgetsPropType,
};